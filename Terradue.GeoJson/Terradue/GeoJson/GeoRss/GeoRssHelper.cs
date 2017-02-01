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

using System.Xml;
using System.Xml.Linq;
using Terradue.GeoJson.Geometry;

namespace Terradue.GeoJson.GeoRss {
    
    using System;
    using System.Xml.Serialization;

  public static class GeoRssHelper {

		static XmlSerializer geoRssWhereSerializer = new XmlSerializer(typeof(GeoRssWhere));
		static XmlSerializer geoRssPointSerializer = new XmlSerializer(typeof(GeoRssPoint));
		static XmlSerializer geoRssLineSerializer = new XmlSerializer(typeof(GeoRssLine));
		static XmlSerializer geoRssPolygonSerializer = new XmlSerializer(typeof(GeoRssPolygon));
		static XmlSerializer geoRssBoxSerializer = new XmlSerializer(typeof(GeoRssBox));
		static XmlSerializer geoRssFeatureTypeSerializer = new XmlSerializer(typeof(GeoRssFeatureType));
		static XmlSerializer geoRssFeatureNameSerializer = new XmlSerializer(typeof(GeoRssFeatureName));
		static XmlSerializer geoRssElevationSerializer = new XmlSerializer(typeof(GeoRssElevation));
		static XmlSerializer geoRssRelationshipTagSerializer = new XmlSerializer(typeof(GeoRssRelationshipTag));
		static XmlSerializer geoRssRadiusSerializer = new XmlSerializer(typeof(GeoRssRadius));


		public static IGeoRSS Deserialize(XmlReader reader) {


            var node = XElement.Load(reader);
            reader = node.CreateReader();

            if (node.Name.NamespaceName != "http://www.georss.org/georss")
                throw new InvalidFormatException("The xml is not GeoRSS");

            if (node.Name.LocalName == "where") {
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssWhere));
                return (GeoRssWhere)geoRssWhereSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "point") {
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssPoint));
                return (GeoRssPoint)geoRssPointSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "line") {
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssLine));
                return (GeoRssLine)geoRssLineSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "polygon") {
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssPolygon));
                return (GeoRssPolygon)geoRssPolygonSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "box") {
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssBox));
                return (GeoRssBox)geoRssBoxSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "featuretypetag") {
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssFeatureType));
                return (GeoRssFeatureType)geoRssFeatureTypeSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "featurename") {
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssFeatureName));
                return (GeoRssFeatureName)geoRssFeatureNameSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "relationshiptag") {
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssRelationshipTag));
                return (GeoRssRelationshipTag)geoRssRelationshipTagSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "elev") {
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssElevation));
                return (GeoRssElevation)geoRssElevationSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "radius") {
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssRadius));
                return (GeoRssRadius)geoRssRadiusSerializer.Deserialize(reader);
            }

            throw new NotImplementedException();

        }

        public static void Serialize(XmlWriter writer, IGeoRSS georss) {

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);
            namespaces.Add("georss", "http://www.georss.org/georss");

            if (georss is GeoRssWhere) {
                namespaces.Add("gml", "http://www.opengis.net/gml");
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssWhere));
                geoRssWhereSerializer.Serialize(writer,georss,namespaces);
            }

            if (georss is GeoRssPoint) {
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssPoint));
                geoRssPointSerializer.Serialize(writer,georss,namespaces);
            }

            if (georss is GeoRssLine) {
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssLine));
                geoRssLineSerializer.Serialize(writer,georss,namespaces);
            }

            if (georss is GeoRssPolygon) {
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssPolygon));
                geoRssPolygonSerializer.Serialize(writer,georss,namespaces);
            }

            if (georss is GeoRssBox) {
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssBox));
                geoRssBoxSerializer.Serialize(writer,georss,namespaces);
            }

            if (georss is GeoRssFeatureType) {
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssFeatureType));
                geoRssFeatureTypeSerializer.Serialize(writer,georss,namespaces);
            }

            if (georss is GeoRssFeatureName) {
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssFeatureName));
                geoRssFeatureNameSerializer.Serialize(writer,georss,namespaces);
            }

            if (georss is GeoRssRelationshipTag) {
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssRelationshipTag));
                geoRssRelationshipTagSerializer.Serialize(writer,georss,namespaces);
            }

            if (georss is GeoRssElevation) {
                //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssElevation));
				geoRssElevationSerializer.Serialize(writer,georss,namespaces);
            }

            if (georss is GeoRssRadius) {
                //XmlSerializer geoRssSerialize3r = new XmlSerializer(typeof(GeoRssRadius));
				geoRssRadiusSerializer.Serialize(writer,georss,namespaces);
            }
                
        }

    }
    
}
