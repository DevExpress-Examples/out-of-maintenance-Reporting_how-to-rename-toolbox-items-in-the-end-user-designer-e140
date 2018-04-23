Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing.Design
Imports DevExpress.XtraReports.UserDesigner
' ...


Namespace docEUDRenameToolboxItems
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			' Create a new End-User Designer.
			Dim designForm As New XRDesignFormEx()

			' Handle the event when the report is loaded into the End-User Designer.
			AddHandler designForm.DesignPanel.DesignerHostLoaded, AddressOf OnDesignerLoaded

			' Load the report into the designer. 
			designForm.OpenReport(New XtraReport1())

			' Show the End-User Designer window.
			designForm.Show()
		End Sub

		Private Sub OnDesignerLoaded(ByVal sender As Object, ByVal e As DesignerLoadedEventArgs)
			' Get the toolbox service.
			Dim ts As IToolboxService = CType(e.DesignerHost.GetService(GetType(IToolboxService)), IToolboxService)

			' Get a collection of toolbox items.
			Dim coll As ToolboxItemCollection = ts.GetToolboxItems()

			' Iterate through toolbox items.
			For Each item As ToolboxItem In coll
				' Add the "Cool" prefix to all toolbox item names.
				item.DisplayName = "Cool " & item.DisplayName
			Next item
		End Sub

	End Class
End Namespace