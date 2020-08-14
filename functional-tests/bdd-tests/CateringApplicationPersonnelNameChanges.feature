﻿Feature: CateringApplicationPersonnelNameChanges
    As a logged in business user
    I want to pay the first year catering licence fee
    And submit personnel name and email changes for different business types

@e2e @catering @partnership @cateringemailpartner
Scenario: Catering Partnership Personnel Email Change
    Given I am logged in to the dashboard as a partnership
    And I click on the Start Application button for Catering
    And I review the account profile for a partnership
    And I review the organization structure for a partnership
    And I click on the button for Submit Organization Information
    And I complete the Catering application
    And I click on the Submit button
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Catering
    And I request a personnel name change for a partnership
    And I confirm the correct personnel name change fee for a Catering licence
    And I confirm that the director name has been updated
    And I change a personnel email address for a partnership
    And the account is deleted
    Then I see the login page

@e2e @catering @privatecorporation @cateringemailprivcorp
Scenario: Catering Private Corporation Personnel Email Change
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for Catering
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Catering application
    And I click on the Submit button
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Catering
    And I request a personnel name change for a private corporation
    And I confirm the correct personnel name change fee for a Catering licence
    And I confirm that the director name has been updated
    And I change a personnel email address for a private corporation
    And the account is deleted
    Then I see the login page

@e2e @catering @publiccorporation @cateringemailpubcorp
Scenario: Catering Public Corporation Personnel Email Change
    Given I am logged in to the dashboard as a public corporation
    And I click on the Start Application button for Catering
    And I review the account profile for a public corporation
    And I review the organization structure for a public corporation
    And I click on the button for Submit Organization Information
    And I complete the Catering application
    And I click on the Submit button
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Catering
    And I request a personnel name change for a public corporation
    And I confirm the correct personnel name change fee for a Catering licence
    And I confirm that the director name has been updated
    And I change a personnel email address for a public corporation
    And the account is deleted
    Then I see the login page

@e2e @catering @society @cateringemailsociety
Scenario: Catering Society Personnel Email Change
    Given I am logged in to the dashboard as a society
    And I click on the Start Application button for Catering
    And I review the account profile for a society
    And I review the organization structure for a society
    And I click on the button for Submit Organization Information
    And I complete the Catering application
    And I click on the Submit button
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Catering
    And I request a personnel name change for a society
    And I confirm the correct personnel name change fee for a Catering licence
    And I confirm that the director name has been updated
    And I change a personnel email address for a society
    And the account is deleted
    Then I see the login page

@e2e @catering @soleproprietorship @cateringemailsoleprop
Scenario: Catering Sole Proprietorship Personnel Email Change
    Given I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for Catering
    And I review the account profile for a sole proprietorship
    And I review the organization structure for a sole proprietorship
    And I click on the button for Submit Organization Information
    And I complete the Catering application
    And I click on the Submit button
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Catering
    And I request a personnel name change for a sole proprietorship
    And I confirm the correct personnel name change fee for a Catering licence
    And I confirm that the director name has been updated
    And I change a personnel email address for a sole proprietorship
    And the account is deleted
    Then I see the login page