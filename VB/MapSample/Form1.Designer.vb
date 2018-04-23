Imports Microsoft.VisualBasic
Imports System
Namespace MapSample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.mapControl1 = New DevExpress.XtraMap.MapControl()
			Me.vectorItemsLayer1 = New DevExpress.XtraMap.VectorItemsLayer()
			Me.shapefileDataAdapter1 = New DevExpress.XtraMap.ShapefileDataAdapter()
			Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
			Me.btnShp = New DevExpress.XtraEditors.SimpleButton()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btnPrj = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' mapControl1
			' 
			Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mapControl1.Layers.Add(Me.vectorItemsLayer1)
			Me.mapControl1.Location = New System.Drawing.Point(200, 0)
			Me.mapControl1.Name = "mapControl1"
			Me.mapControl1.Size = New System.Drawing.Size(609, 476)
			Me.mapControl1.TabIndex = 0
			Me.vectorItemsLayer1.Data = Me.shapefileDataAdapter1
'			Me.vectorItemsLayer1.DataLoaded += New DevExpress.XtraMap.DataLoadedEventHandler(Me.vectorItemsLayer1_DataLoaded);
			' 
			' btnSave
			' 
			Me.btnSave.Enabled = False
			Me.btnSave.Location = New System.Drawing.Point(5, 63)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New System.Drawing.Size(189, 23)
			Me.btnSave.TabIndex = 1
			Me.btnSave.Text = "3.Save Geo Shape File"
'			Me.btnSave.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' btnShp
			' 
			Me.btnShp.Location = New System.Drawing.Point(5, 5)
			Me.btnShp.Name = "btnShp"
			Me.btnShp.Size = New System.Drawing.Size(189, 23)
			Me.btnShp.TabIndex = 2
			Me.btnShp.Text = "1. Open Cartesian Shape File (*.shp)"
'			Me.btnShp.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btnShp)
			Me.panelControl1.Controls.Add(Me.btnSave)
			Me.panelControl1.Controls.Add(Me.btnPrj)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(200, 476)
			Me.panelControl1.TabIndex = 3
			' 
			' btnPrj
			' 
			Me.btnPrj.Location = New System.Drawing.Point(5, 34)
			Me.btnPrj.Name = "btnPrj"
			Me.btnPrj.Size = New System.Drawing.Size(189, 23)
			Me.btnPrj.TabIndex = 3
			Me.btnPrj.Text = "2. Open Projection File (*.prj)"
'			Me.btnPrj.Click += New System.EventHandler(Me.simpleButton3_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(809, 476)
			Me.Controls.Add(Me.mapControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private mapControl1 As DevExpress.XtraMap.MapControl
		Private WithEvents vectorItemsLayer1 As DevExpress.XtraMap.VectorItemsLayer
		Private shapefileDataAdapter1 As DevExpress.XtraMap.ShapefileDataAdapter
		Private WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnShp As DevExpress.XtraEditors.SimpleButton
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents btnPrj As DevExpress.XtraEditors.SimpleButton

	End Class
End Namespace

