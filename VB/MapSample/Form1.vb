Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraMap
Imports System.IO

Namespace MapSample
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub


		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			Dim dialog As New SaveFileDialog()
			dialog.DefaultExt = ".shp" ' Default file extension
			dialog.Filter = "Shape file (.shp)|*.shp" ' Filter files by extension

			If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Dim vl As VectorItemsLayer = TryCast(Me.mapControl1.Layers(0), VectorItemsLayer)
				If vl IsNot Nothing Then
					vl.ExportToShp(dialog.FileName, New ShpExportOptions() With {.ExportToDbf = True, .ShapeType = ShapeType.PolygonZ})
					MessageBox.Show("Shape File Saved")
					Return
				End If
				MessageBox.Show("An error occured")
			End If
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShp.Click
			Dim dialog As New OpenFileDialog()
			dialog.DefaultExt = ".shp" ' Default file extension
			dialog.Filter = "Shape file (.shp)|*.shp" ' Filter files by extension

			If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				shapefileDataAdapter1.FileUri = New Uri(dialog.FileName)
				Dim projectionPath As String = dialog.FileName.Substring(0, dialog.FileName.Length-3) & "prj"

				If File.Exists(projectionPath) Then
					btnSave.Enabled = True
					btnPrj.Text = "2. Projection Loaded automatically"
					btnPrj.Enabled = False

				Else
					btnPrj.Text = "2. Open Projection File (*.prj)"
					btnPrj.Enabled = True
					btnSave.Enabled = False
				End If
			End If
		End Sub

		Private Sub vectorItemsLayer1_DataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs) Handles vectorItemsLayer1.DataLoaded
				mapControl1.ZoomToFitLayerItems()
		End Sub

		Private Sub simpleButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrj.Click
			Dim dialog As New OpenFileDialog()
			dialog.DefaultExt = ".prj" ' Default file extension
			dialog.Filter = "Shape file (.prj)|*.prj" ' Filter files by extension

			If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				shapefileDataAdapter1.SourceCoordinateSystem= ShapefileDataAdapter.LoadPrjFile(New Uri(dialog.FileName))
				btnSave.Enabled = True
			End If
		End Sub
	End Class
End Namespace
