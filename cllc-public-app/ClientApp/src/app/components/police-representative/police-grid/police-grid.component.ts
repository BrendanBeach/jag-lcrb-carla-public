import { Component, Input, OnInit, ViewChild  } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { PoliceTableElement } from '../police-table-element';
import { Subscription } from "rxjs";
import { SpecialEventsDataService } from '@services/special-events-data.service';
import { SelectionModel } from '@angular/cdk/collections';
import { MatSelectChange } from '@angular/material/select';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { Contact } from '@models/contact.model';
import { User } from '@models/user.model';

@Component({
  selector: 'app-police-grid',
  templateUrl: './police-grid.component.html',
  styleUrls: ['./police-grid.component.scss']
})
export class PoliceGridComponent implements OnInit {
  busy: Subscription;
  _dataSource: MatTableDataSource<PoliceTableElement>
  _availableContacts: Contact[];
  _currentUser: User;
  currentValueMap = {};

  // angular material table columns to display
  columnsToDisplay = ['select', 'dateSubmitted', 'eventName', 'eventStartDate', 'eventStatusLabel', 'policeDecisionByLabel', 'maximumNumberOfGuests', 'typeOfEventLabel', 'actions'];

  
  // table state
  initialSelection = [];
  allowMultiSelect = true;
  selection = new SelectionModel<PoliceTableElement>(this.allowMultiSelect, this.initialSelection);


  @ViewChild(MatSort, { static: true }) sort: MatSort;
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;

  @Input()
  set dataSource(value: MatTableDataSource<PoliceTableElement>) {
    this._dataSource = value;  
  };
  get dataSource() {
    return this._dataSource;
  }

  @Input()
  set availableContacts(value: Contact[]) {
    this._availableContacts = value;  
  };
  get availableContacts() {
    return this._availableContacts;
  }

  @Input()
  set currentUser(value: User) {
    this._currentUser = value;  
  };
  get currentUser() {
    return this._currentUser;
  }

  constructor(    private sepDataService: SpecialEventsDataService) { }

  ngOnInit(): void {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  
  isAssigned(sepData: PoliceTableElement): boolean {
    // TODO: Implement logic to show appropriate button text when application has been assigned
    return sepData.policeDecisionBy != null;
  }

  assign(row: PoliceTableElement) {
    // TODO: Call backend endpoint to update/assign this SEP Application
    var assignee = this.currentValueMap['assignee_' + row.specialEventId];
    this.busy = this.sepDataService.policeAssignSepApplication(row.specialEventId, assignee)
      .subscribe(() => console.log ("refresh"));
    
  }

  batchAssign() {
    // TODO: Call backend endpoint for batch updates/assignments
    const selected = this.selection.selected;
    console.log(`Call API to batch assign SEP applications:`);
    selected.forEach(x => console.log(`${x.specialEventId}`));
  }

  /** Whether the number of selected elements matches the total number of rows. */
  isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.dataSource.data.length;
    return numSelected === numRows;
  }

  /** Selects all rows if they are not all selected; otherwise clear selection. */
  masterToggle() {
    this.isAllSelected() ?
      this.selection.clear() :
      this.dataSource.data.forEach(row => this.selection.select(row));
  }

  updateValue(event: MatSelectChange) {
    this.currentValueMap[event.source.id] = event.value;
  }

}