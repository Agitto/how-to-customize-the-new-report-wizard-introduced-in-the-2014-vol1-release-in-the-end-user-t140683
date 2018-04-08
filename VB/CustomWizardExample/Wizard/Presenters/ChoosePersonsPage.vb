﻿Imports System
Imports System.Collections.Generic
Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraReports.Wizards3
Imports DevExpress.XtraReports.Wizards3.Views
Imports DevExpress.Data.XtraReports.Wizard
Imports DevExpress.DataAccess.Wizard
Imports DevExpress.DataAccess.Wizard.Services
Imports DevExpress.Entity.ProjectModel

Namespace CustomWizardExample.Wizard.Presenters
	Friend Class ChoosePersonsPage
		Inherits DevExpress.XtraReports.Wizards3.Presenters.ChooseReportTypePageEx(Of XtraReportModel)
		Public Sub New(ByVal view As IChooseReportTypePageViewExtended, dataConnections As IEnumerable(Of SqlDataConnection), dataSourceTypes As DataSourceTypes, context As IWizardRunnerContext, solutionTypesProvider As ISolutionTypesProvider)
            MyBase.New(view, dataConnections, dataSourceTypes, context, solutionTypesProvider)
        End Sub
		Public Overrides Function GetNextPageType() As Type
			Return If((View.ReportType = ReportType.Standard), GetType(ChoosePersonsPage2(Of XtraReportModel)), MyBase.GetNextPageType())
		End Function
	End Class
End Namespace
