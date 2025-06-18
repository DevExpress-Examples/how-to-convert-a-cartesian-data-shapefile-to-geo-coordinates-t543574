<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576249/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T543574)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Map for WinForms - How to Convert a Cartesian Data Shapefile to Geo Coordinates 

Two types of coordinate systems are used when you create a map: [Cartesian coordinate](http://en.wikipedia.org/wiki/Cartesian_coordinate_system) and [Geographic coordinate](http://en.wikipedia.org/wiki/Geographic_coordinate_system). This example opens a shape file with Cartesian coordinates and saves it to a shape file with Geo coordinates. 

## Implementation Details 

To convert Cartesian coordinates to Geo coordinates, MapControl requires information about the projection used in a shape file to represent a spherical surface in Cartesian coordinates. MapControl can load the required information from the projection (*.PRJ) file. If your data contains the *.PRJ file and this file is located in the same directory and has the same name as a shapefile, the coordinate system will be loaded automatically. Otherwise, if the paths or the names are different, call the [ShapefileDataAdapter.LoadPrjFile](https://documentation.devexpress.com/WindowsForms/DevExpress.XtraMap.ShapefileDataAdapter.LoadPrjFile.overloads) method to load the coordinate system's metadata. To convert a shape file with this example, run the project, then open a shape file and its projection file (if it has not been found automatically), and then save the map to a new shape file.

## Files to Review

* [Form1.cs](./CS/MapSample/Form1.cs) (VB: [Form1.vb](./VB/MapSample/Form1.vb))
* [Program.cs](./CS/MapSample/Program.cs) (VB: [Program.vb](./VB/MapSample/Program.vb))

## Documentation
* [Provide Cartesian Data to a Geographical Map](https://documentation.devexpress.com/WindowsForms/18181/Controls-and-Libraries/Map-Control/Coordinate-Systems/Provide-Cartesian-Data-to-a-Geographical-Map)
* [Geographical Projections](https://documentation.devexpress.com/WindowsForms/15079/Controls-and-Libraries/Map-Control/Coordinate-Systems/Geographical-Projections)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-map-convert-a-cartesian-data-shapefile-to-geo-coordinates&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-map-convert-a-cartesian-data-shapefile-to-geo-coordinates&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
