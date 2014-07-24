﻿using NUnit.Framework;
using System;
using System.Xml;
using Terradue.GeoJson.Geometry;
using Terradue.GeoJson.Feature;

namespace Terradue.GeoJson.Tests { 

    [TestFixture()]
    public class GmlTest {

        [Test()]
        public void MultiCurveWithLinearStringTestCase() {

            XmlDocument doc = new XmlDocument();
            doc.Load("../MultiCurveWithLinearString.gml");

            XmlElement e = doc.DocumentElement;

            var geom = GeometryFactory.GmlToGeometry(e);

            Assert.IsTrue(geom is MultiLineString);

            var feature = GeometryFactory.GmlToFeature(e);

            Assert.IsTrue(feature is MultiLineStringFeature);

            MultiLineStringFeature feature2 = new MultiLineStringFeature((MultiLineString)feature.Geometry, feature.Properties);

            Assert.IsTrue(feature2 is MultiLineStringFeature);

        }
    }
}

