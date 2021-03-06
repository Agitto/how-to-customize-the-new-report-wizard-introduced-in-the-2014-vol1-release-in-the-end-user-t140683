﻿Imports System
Imports DevExpress.XtraReports.Wizards

Namespace CustomWizardExample.Wizard.Presenters
    Public Class ChoosePersonsPage3
        Inherits ChoosePersonsPage2(Of XtraReportModel)

        Public Sub New(ByVal view As Views.IChoosePersonsPageView)
            MyBase.New(view)
        End Sub

        Public Overrides Function GetNextPageType() As Type
            Return GetType(DevExpress.XtraReports.Wizards.Presenters.SelectColumnsPage(Of XtraReportModel))
        End Function
        Public Overrides ReadOnly Property MoveNextEnabled() As Boolean
            Get
                Return True
            End Get
        End Property
        Public Overrides ReadOnly Property FinishEnabled() As Boolean
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
