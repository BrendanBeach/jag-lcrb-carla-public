export class SepApplication {
    id: number
    tempJobNumber: string;
    dateCreated: Date;
    lastUpdated: Date;
    eventName: string;
    applicantInfo: any;
    agreeToTnC: boolean;
    dateAgreedToTnC: Date;
    stepsCompleted: string[];
    status: string;

    eligibilityAtPrivateResidence: boolean;
    eligibilityMajorSignificance: boolean;
    eligibilityMajorSignificanceRational: string;
    eligibilityLocalSignificance: boolean;

}