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

using System;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Terradue.GeoJson.Geometry;

namespace Terradue.GeoJson.GeoRss
{
  public static class GeoRssHelper
  {
    private static readonly XmlSerializer geoRssWhereSerializer = new XmlSerializer(typeof(GeoRssWhere));
    private static readonly XmlSerializer geoRssPointSerializer = new XmlSerializer(typeof(GeoRssPoint));
    private static readonly XmlSerializer geoRssLineSerializer = new XmlSerializer(typeof(GeoRssLine));
    private static readonly XmlSerializer geoRssPolygonSerializer = new XmlSerializer(typeof(GeoRssPolygon));
    private static readonly XmlSerializer geoRssBoxSerializer = new XmlSerializer(typeof(GeoRssBox));
    private static readonly XmlSerializer geoRssFeatureTypeSerializer = new XmlSerializer(typeof(GeoRssFeatureType));
    private static readonly XmlSerializer geoRssFeatureNameSerializer = new XmlSerializer(typeof(GeoRssFeatureName));
    private static readonly XmlSerializer geoRssElevationSerializer = new XmlSerializer(typeof(GeoRssElevation));

    private static readonly XmlSerializer geoRssRelationshipTagSerializer =
      new XmlSerializer(typeof(GeoRssRelationshipTag));

    private static readonly XmlSerializer geoRssRadiusSerializer = new XmlSerializer(typeof(GeoRssRadius));


    public static IGeoRSS Deserialize(XmlReader reader)
    {
      var node = XElement.Load(reader);
      reader = node.CreateReader();

      if (node.Name.NamespaceName != "http://www.georss.org/georss")
        throw new InvalidFormatException("The xml is not GeoRSS");

      if (node.Name.LocalName == "where") return (GeoRssWhere) geoRssWhereSerializer.Deserialize(reader);

      if (node.Name.LocalName == "point") return (GeoRssPoint) geoRssPointSerializer.Deserialize(reader);

      if (node.Name.LocalName == "line") return (GeoRssLine) geoRssLineSerializer.Deserialize(reader);

      if (node.Name.LocalName == "polygon") return (GeoRssPolygon) geoRssPolygonSerializer.Deserialize(reader);

      if (node.Name.LocalName == "box") return (GeoRssBox) geoRssBoxSerializer.Deserialize(reader);

      if (node.Name.LocalName == "featuretypetag")
        return (GeoRssFeatureType) geoRssFeatureTypeSerializer.Deserialize(reader);

      if (node.Name.LocalName == "featurename")
        return (GeoRssFeatureName) geoRssFeatureNameSerializer.Deserialize(reader);

      if (node.Name.LocalName == "relationshiptag")
        return (GeoRssRelationshipTag) geoRssRelationshipTagSerializer.Deserialize(reader);

      if (node.Name.LocalName == "elev") return (GeoRssElevation) geoRssElevationSerializer.Deserialize(reader);

      if (node.Name.LocalName == "radius") return (GeoRssRadius) geoRssRadiusSerializer.Deserialize(reader);

      throw new NotImplementedException();
    }

    public static void Serialize(XmlWriter writer, IGeoRSS georss)
    {
      var namespaces = new XmlSerializerNamespaces();
      namespaces.Add(string.Empty, string.Empty);
      namespaces.Add("georss", "http://www.georss.org/georss");

      if (georss is GeoRssWhere)
      {
        namespaces.Add("gml", "http://www.opengis.net/gml");
        //XmlSerializer geoRssSerializer = new XmlSerializer(typeof(GeoRssWhere));
        geoRssWhereSerializer.Serialize(writer, georss, namespaces);
      }

      if (georss is GeoRssPoint) geoRssPointSerializer.Serialize(writer, georss, namespaces);

      if (georss is GeoRssLine) geoRssLineSerializer.Serialize(writer, georss, namespaces);

      if (georss is GeoRssPolygon) geoRssPolygonSerializer.Serialize(writer, georss, namespaces);

      if (georss is GeoRssBox) geoRssBoxSerializer.Serialize(writer, georss, namespaces);

      if (georss is GeoRssFeatureType) geoRssFeatureTypeSerializer.Serialize(writer, georss, namespaces);

      if (georss is GeoRssFeatureName) geoRssFeatureNameSerializer.Serialize(writer, georss, namespaces);

      if (georss is GeoRssRelationshipTag) geoRssRelationshipTagSerializer.Serialize(writer, georss, namespaces);

      if (georss is GeoRssElevation) geoRssElevationSerializer.Serialize(writer, georss, namespaces);

      if (georss is GeoRssRadius) geoRssRadiusSerializer.Serialize(writer, georss, namespaces);
    }
  }
}