//
//  GeoRssHelper.cs
//
//  Author:
//       Emmanuel Mathot <emmanuel.mathot@terradue.com>
//
//  Copyright (c) 2016 Terradue
//
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
//

using Terradue.ServiceModel.Ogc.Gml311;
using System.Xml;
using System.Xml.Linq;
using Terradue.GeoJson.Geometry;

namespace Terradue.GeoJson.GeoRss {
    
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;

    public static class GeoRssHelper {

        public static IGeoRSS Deserialize(XmlReader reader) {

            var node = XElement.Load(reader);
            reader = node.CreateReader();

            if (node.Name.NamespaceName != "http://www.georss.org/georss")
                throw new InvalidFormatException("The xml is not GeoRSS");

            if (node.Name.LocalName == "where") {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssWhere));
                return (GeoRssWhere)geoRssSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "point") {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssPoint));
                return (GeoRssPoint)geoRssSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "line") {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssLine));
                return (GeoRssLine)geoRssSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "polygon") {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssPolygon));
                return (GeoRssPolygon)geoRssSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "box") {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssBox));
                return (GeoRssBox)geoRssSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "featuretypetag") {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssFeatureType));
                return (GeoRssFeatureType)geoRssSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "featurename") {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssFeatureName));
                return (GeoRssFeatureName)geoRssSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "relationshiptag") {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssRelationshipTag));
                return (GeoRssRelationshipTag)geoRssSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "elev") {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssElevation));
                return (GeoRssElevation)geoRssSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "radius") {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssRadius));
                return (GeoRssRadius)geoRssSerializer.Deserialize(reader);
            }

            throw new NotImplementedException();

        }

        public static void Serialize(XmlWriter writer, IGeoRSS georss) {

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);
            namespaces.Add("georss", "http://www.georss.org/georss");

            if (georss is GeoRssWhere) {
                namespaces.Add("gml", "http://www.opengis.net/gml");
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssWhere));
                geoRssSerializer.Serialize(writer,georss,namespaces);
            }

            if (georss is GeoRssPoint) {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssPoint));
                geoRssSerializer.Serialize(writer,georss,namespaces);
            }

            if (georss is GeoRssLine) {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssLine));
                geoRssSerializer.Serialize(writer,georss,namespaces);
            }

            if (georss is GeoRssPolygon) {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssPolygon));
                geoRssSerializer.Serialize(writer,georss,namespaces);
            }

            if (georss is GeoRssBox) {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssBox));
                geoRssSerializer.Serialize(writer,georss,namespaces);
            }

            if (georss is GeoRssFeatureType) {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssFeatureType));
                geoRssSerializer.Serialize(writer,georss,namespaces);
            }

            if (georss is GeoRssFeatureName) {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssFeatureName));
                geoRssSerializer.Serialize(writer,georss,namespaces);
            }

            if (georss is GeoRssRelationshipTag) {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssRelationshipTag));
                geoRssSerializer.Serialize(writer,georss,namespaces);
            }

            if (georss is GeoRssElevation) {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssElevation));
                geoRssSerializer.Serialize(writer,georss,namespaces);
            }

            if (georss is GeoRssRadius) {
                XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssRadius));
                geoRssSerializer.Serialize(writer,georss,namespaces);
            }
                
        }

    }
    
}
