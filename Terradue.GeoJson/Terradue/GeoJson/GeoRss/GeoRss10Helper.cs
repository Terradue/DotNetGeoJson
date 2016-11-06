//
//  GeoRss10Helper.cs
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

namespace Terradue.GeoJson.GeoRss10
{
  public static class GeoRss10Helper
  {
    public static IGeoRSS Deserialize(XmlReader reader)
    {
      var node = XElement.Load(reader);
      reader = node.CreateReader();

      if (node.Name.NamespaceName != "http://www.georss.org/georss/10")
        throw new InvalidFormatException("The xml is not GeoRSS");

      if (node.Name.LocalName == "where")
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10Where));
        return (GeoRss10Where) geoRssSerializer.Deserialize(reader);
      }

      if (node.Name.LocalName == "point")
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10Point));
        return (GeoRss10Point) geoRssSerializer.Deserialize(reader);
      }

      if (node.Name.LocalName == "line")
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10Line));
        return (GeoRss10Line) geoRssSerializer.Deserialize(reader);
      }

      if (node.Name.LocalName == "polygon")
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10Polygon));
        return (GeoRss10Polygon) geoRssSerializer.Deserialize(reader);
      }

      if (node.Name.LocalName == "box")
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10Box));
        return (GeoRss10Box) geoRssSerializer.Deserialize(reader);
      }

      if (node.Name.LocalName == "featuretypetag")
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10FeatureType));
        return (GeoRss10FeatureType) geoRssSerializer.Deserialize(reader);
      }

      if (node.Name.LocalName == "featurename")
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10FeatureName));
        return (GeoRss10FeatureName) geoRssSerializer.Deserialize(reader);
      }

      if (node.Name.LocalName == "relationshiptag")
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10RelationshipTag));
        return (GeoRss10RelationshipTag) geoRssSerializer.Deserialize(reader);
      }

      if (node.Name.LocalName == "elev")
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10Elevation));
        return (GeoRss10Elevation) geoRssSerializer.Deserialize(reader);
      }

      if (node.Name.LocalName == "radius")
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10Radius));
        return (GeoRss10Radius) geoRssSerializer.Deserialize(reader);
      }

      throw new NotImplementedException();
    }

    public static void Serialize(XmlWriter writer, IGeoRSS georss)
    {
      var namespaces = new XmlSerializerNamespaces();
      namespaces.Add(string.Empty, string.Empty);
      namespaces.Add("georss", "http://www.georss.org/georss");

      if (georss is GeoRss10Where)
      {
        namespaces.Add("gml", "http://www.opengis.net/gml");
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10Where));
        geoRssSerializer.Serialize(writer, georss, namespaces);
      }

      if (georss is GeoRss10Point)
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10Point));
        geoRssSerializer.Serialize(writer, georss, namespaces);
      }

      if (georss is GeoRss10Line)
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10Line));
        geoRssSerializer.Serialize(writer, georss, namespaces);
      }

      if (georss is GeoRss10Polygon)
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10Polygon));
        geoRssSerializer.Serialize(writer, georss, namespaces);
      }

      if (georss is GeoRss10Box)
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10Box));
        geoRssSerializer.Serialize(writer, georss, namespaces);
      }

      if (georss is GeoRss10FeatureType)
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10FeatureType));
        geoRssSerializer.Serialize(writer, georss, namespaces);
      }

      if (georss is GeoRss10FeatureName)
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10FeatureName));
        geoRssSerializer.Serialize(writer, georss, namespaces);
      }

      if (georss is GeoRss10RelationshipTag)
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10RelationshipTag));
        geoRssSerializer.Serialize(writer, georss, namespaces);
      }

      if (georss is GeoRss10Elevation)
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10Elevation));
        geoRssSerializer.Serialize(writer, georss, namespaces);
      }

      if (georss is GeoRss10Radius)
      {
        var geoRssSerializer = new XmlSerializer(typeof(GeoRss10Radius));
        geoRssSerializer.Serialize(writer, georss, namespaces);
      }
    }
  }
}