# DotNetGeoJson - GeoJson library for .Net

Terradue.GeoJson is a library targeting .NET 4.0 and above providing an easy
way to manage GeoJson objects with serialization and deserialization functions based on [ServiceStack](https://github.com/ServiceStack/ServiceStack)
and transformation functions from [GML](http://en.wikipedia.org/wiki/Geography_Markup_Language) and [Well Known Text (WKT)](http://en.wikipedia.org/wiki/Well-known_text)

## Usage examples

Serialize 

```c#
var feature = GeometryFactory.WktToFeature("MULTIPOLYGON(((-35.8564 76.3201,-24.3168 86.6627,-35.8318 86.7731,-47.6561 86.7495,-58.8572 86.5946,-66.4273 86.4019,-75.1745 86.0612,-82.4096 85.6457,-88.3271 85.1747,-94.2379 84.5298,-98.0433 83.9814,-102.611 83.1211,-106.698 82.0776,-109.452 81.1601,-112.048 80.071,-114.95 78.4909,-117.401 76.7308,-119.334 74.9554,-120.913 73.1694,-122.124 71.539,-123.467 69.4122,-124.777 66.9507,-126.041 64.1534,-127.137 61.3499,-128.164 58.3761,-129.332 54.5695,-131.148 47.7685,-133.199 38.9534,-140.184 5.21524,-143.393 -9.14381,-145.178 -16.2998,-146.908 -22.6017,-148.621 -28.2163,-150.479 -33.6374,-152.391 -38.5343,-154.348 -42.9085,-156.51 -47.0827,-158.823 -50.8932,-161.17 -54.1839,-163.769 -57.269,-166.662 -60.1427,-169.7 -62.6524,-146.91 -66.483,-145.417 -63.0394,-143.765 -58.4344,-142.267 -53.4868,-140.824 -48.0312,-139.403 -42.0658,-137.976 -35.5891,-132.316 -8.07001,-129.522 4.79458,-128.027 11.1346,-126.549 16.963,-125.087 22.2781,-123.592 27.245,-121.827 32.5203,-119.965 37.4381,-118.139 41.672,-116.314 45.3893,-114.333 48.914,-112.169 52.2423,-109.92 55.2151,-107.466 57.9885,-105.12 60.2592,-102.436 62.4837,-99.3325 64.65,-96.4819 66.3306,-92.9457 68.0854,-89.5209 69.5039,-85.63 70.8476,-81.6291 71.9901,-76.6541 73.141,-72.0977 73.9842,-66.5 74.7977,-60.9886 75.4017,-55.0708 75.8679,-48.1172 76.2077,-41.6493 76.3417,-35.8564 76.3201)))");
var fc = new FeatureCollection(new Terradue.GeoJson.Feature.Feature[]{feature}.ToList());
JsonSerializer.SerializeToStream(fc, Console.OpenStandardOutput());
```

## Supported Platforms

* .NET 4.0 (Desktop / Server)
* Xamarin.iOS / Xamarin.Android / Xamarin.Mac
* Mono 2.10+

## Getting Started

Terradue.GeoJson is available as NuGet package in releases.

```
Install-Package Terradue.GeoJson
```

## Build

Terradue.GeoJson is a single assembly designed to be easily deployed anywhere. 

To compile it yourself, you’ll need:

* Visual Studio 2012 or later, or Xamarin Studio

To clone it locally, click the "Clone in Desktop" button above or run the 
following git commands.

```
git clone git@github.com:Terradue/Terradue.GeoJson.git Terradue.GeoJson
cd Terradue.GeoJson
./configure
./make
```

## Copyright and License

Copyright (c) 2014 Terradue

Licensed under the [GPL v2 License](https://github.com/Terradue.GeoJson/Terradue.GeoJson/blob/master/LICENSE.txt)

Adapted from GeoJSON.Net / https://github.com/jbattermann/GeoJSON.Net

Copyright (c) Jörg Battermann 2011
