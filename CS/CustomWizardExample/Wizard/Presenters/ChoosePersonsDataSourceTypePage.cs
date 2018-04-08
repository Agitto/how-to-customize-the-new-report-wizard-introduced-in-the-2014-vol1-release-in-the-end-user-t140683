﻿using System;
using DevExpress.DataAccess.Wizard;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.XtraReports.Wizards3.Presenters;

namespace CustomWizardExample.Wizard.Presenters {
    public class ChoosePersonsDataSourceTypePage : WizardPageBase<Views.IChoosePersonsDataSourcePageView, Model.CustomReportModel, IDataSourceWizardClient> {
        public ChoosePersonsDataSourceTypePage(Views.IChoosePersonsDataSourcePageView view, IDataSourceWizardClient client) : base(view, client) { }

        public override void Begin() {
            View.DataSourceType = Model.PersonsDataSourceType;
        }

        public override bool Validate(out string errorMessage) {
            errorMessage = string.Empty;
            if(View.DataSourceType == PersonsDataSourceType.Static)
                return View.ShowWarning();
            return true;
        }


        public override void Commit() {
            Model.PersonsDataSourceType = View.DataSourceType;
            Model.DataSchema = new Person();
        }

        public override Type GetNextPageType() { return typeof(SelectColumnsPage<Model.CustomReportModel, IDataSourceWizardClient>); }
        public override bool MoveNextEnabled { get { return true; } }
       
    }
}