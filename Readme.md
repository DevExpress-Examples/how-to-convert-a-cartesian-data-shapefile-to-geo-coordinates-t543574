<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/MapSample/Form1.cs) (VB: [Form1.vb](./VB/MapSample/Form1.vb))
* [Program.cs](./CS/MapSample/Program.cs) (VB: [Program.vb](./VB/MapSample/Program.vb))
<!-- default file list end -->
# How to convert a Cartesian data shapefile to Geo coordinates 


<p>On creating a map, two types of coordinate systems are used: <a href="http://en.wikipedia.org/wiki/Cartesian_coordinate_system">Cartesian coordinate</a> and <a href="http://en.wikipedia.org/wiki/Geographic_coordinate_system">Geographic coordinate</a>. <br><br>This example demonstrates how to open a shape file with Cartesian coordinates and save it to a shape file with Geo coordinates.<br><br>To convert Cartesian coordinates to Geo coordinates, MapControl requires information about the projection used in a shape file to represent a spherical surface in Cartesian coordinates. Refer to the <a href="https://documentation.devexpress.com/WindowsForms/15079/Controls-and-Libraries/Map-Control/Coordinate-Systems/Geographical-Projections">Geographical Projections</a> topic for additional information about projections. MapControl can load the required information from the projection (*.PRJ) file. If your data contains the <em>*.PRJ</em> file and this file is located in the same directory and has the same name as a shapefile, the coordinate system will be loaded automatically. Otherwise, if the paths or the names are different, call the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraMap.ShapefileDataAdapter.LoadPrjFile.overloads">ShapefileDataAdapter.LoadPrjFile</a> method to load the coordinate system's metadata.<br><br>To convert a shape file with this example, run the project, then open a shape file and its projection file (if it has not been found automatically), and then save the map to a new shape file.<br><br>For additional information regarding this conversion, refer to the <a href="https://documentation.devexpress.com/WindowsForms/18181/Controls-and-Libraries/Map-Control/Coordinate-Systems/Provide-Cartesian-Data-to-a-Geographical-Map">Provide Cartesian Data to a Geographical Map</a> topic.</p>

<br/>


