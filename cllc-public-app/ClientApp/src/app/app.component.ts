import { Component, OnInit, Renderer2 } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { User } from './models/user.model';
import { isDevMode } from '@angular/core';
import { Store } from '@ngrx/store';
import { AppState } from './app-state/models/app-state';
import { filter, takeWhile } from 'rxjs/operators';
import { FeatureFlagService } from '@services/feature-flag.service';
import { LegalEntity } from '@models/legal-entity.model';
import { AccountDataService } from '@services/account-data.service';
import { FormBase } from '@shared/form-base';
import { SetCurrentAccountAction } from '@app/app-state/actions/current-account.action';
import { Account } from './models/account.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent extends FormBase implements OnInit {
  businessProfiles: LegalEntity[];
  title = '';
  previousUrl: string;
  public currentUser: User;
  public isNewUser: boolean;
  public isDevMode: boolean;
  isAssociate = false;
  account: Account;

  constructor(
    private renderer: Renderer2,
    private router: Router,
    private store: Store<AppState>,
    private accountDataService: AccountDataService,
    public featureFlagService: FeatureFlagService) {
    super();
    this.isDevMode = isDevMode();
    if (!featureFlagService.initialized) {
      featureFlagService.initialize();
    }
    this.router.events
      .pipe(takeWhile(() => this.componentActive))
      .subscribe((event) => {
        if (event instanceof NavigationEnd) {
          const prevSlug = this.previousUrl;
          let nextSlug = event.url.slice(1);
          if (!nextSlug) { nextSlug = 'home'; }
          if (prevSlug) {
            this.renderer.removeClass(document.body, 'ctx-' + prevSlug);
          }
          if (nextSlug) {
            this.renderer.addClass(document.body, 'ctx-' + nextSlug);
          }
          this.previousUrl = nextSlug;
        }
      });
  }

  ngOnInit(): void {
    this.reloadUser();

    this.store.select(state => state.legalEntitiesState)
      .pipe(takeWhile(() => this.componentActive))
      .pipe(filter(state => !!state))
      .subscribe(state => {
        this.businessProfiles = state.legalEntities;
      });

  }

  reloadUser() {
    this.store.select(state => state.currentUserState.currentUser)
      .pipe(takeWhile(() => this.componentActive))
      .subscribe((data: User) => {
        this.currentUser = data;
        this.isNewUser = this.currentUser && this.currentUser.isNewUser;
        if (this.currentUser && this.currentUser.accountid && this.currentUser.accountid !== '00000000-0000-0000-0000-000000000000') {
          this.accountDataService.loadCurrentAccountToStore(this.currentUser.accountid)
            .subscribe(() => { });
        } else {
          this.store.dispatch(new SetCurrentAccountAction(null));
        }
      });

    this.store.select(state => state.currentAccountState.currentAccount)
      .pipe(takeWhile(() => this.componentActive))
      .subscribe(account => {
        this.account = account;
      });
  }

  showBceidTermsOfUse(): boolean {
    const result =  (this.currentUser
      && this.currentUser.businessname
      && this.currentUser.isNewUser === true)
      || (this.account && !this.account.termsOfUseAccepted);
      return result;
  }

  isIE10orLower() {
    let result, jscriptVersion;
    result = false;

    jscriptVersion = new Function('/*@cc_on return @_jscript_version; @*/')();

    if (jscriptVersion !== undefined) {
      result = true;
    }
    return result;
  }

}
