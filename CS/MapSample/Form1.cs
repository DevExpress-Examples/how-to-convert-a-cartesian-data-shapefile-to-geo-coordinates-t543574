using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraMap;
using System.IO;

namespace MapSample
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = ".shp"; // Default file extension
            dialog.Filter = "Shape file (.shp)|*.shp"; // Filter files by extension

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                VectorItemsLayer vl = this.mapControl1.Layers[0] as VectorItemsLayer;
                if (vl != null)
                {
                    vl.ExportToShp(dialog.FileName, new ShpExportOptions() { ExportToDbf = true, ShapeType = ShapeType.PolygonZ });
                    MessageBox.Show("Shape File Saved");
                    return;
                }
                MessageBox.Show("An error occured");               
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = ".shp"; // Default file extension
            dialog.Filter = "Shape file (.shp)|*.shp"; // Filter files by extension

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                shapefileDataAdapter1.FileUri = new Uri(dialog.FileName);
                string projectionPath = dialog.FileName.Substring(0, dialog.FileName.Length-3) + "prj";

                if (File.Exists(projectionPath))
                {
                    btnSave.Enabled = true;
                    btnPrj.Text = "2. Projection Loaded automatically";
                    btnPrj.Enabled = false;

                }
                else
                {
                    btnPrj.Text = "2. Open Projection File (*.prj)";
                    btnPrj.Enabled = true;
                    btnSave.Enabled = false;
                }
            }
        }

        private void vectorItemsLayer1_DataLoaded(object sender, DataLoadedEventArgs e)
        {
                mapControl1.ZoomToFitLayerItems();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = ".prj"; // Default file extension
            dialog.Filter = "Shape file (.prj)|*.prj"; // Filter files by extension

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                shapefileDataAdapter1.SourceCoordinateSystem= ShapefileDataAdapter.LoadPrjFile(new Uri(dialog.FileName));
                btnSave.Enabled = true;
            }
        }
    }
}
