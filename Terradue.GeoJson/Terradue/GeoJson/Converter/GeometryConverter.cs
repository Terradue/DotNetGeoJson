//
//  MultiPolygonConverter.cs
//
//  Author:
//       Emmanuel Mathot <emmanuel.mathot@terradue.com>
//
//  Copyright (c) 2015 Terradue
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Terradue.GeoJson.Geometry;

namespace Terradue.GeoJson.Converter {
    public class GeometryConverter : JsonConverter {
      #region implemented abstract members of JsonConverter

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            var geom = serializer.Deserialize<JToken>(reader);
            var type = serializer.Deserialize<GeoJsonObjectType>(geom.SelectToken("type").CreateReader());
            var coordReader = geom.SelectToken("coordinates").CreateReader();
            switch (type) {
                case GeoJsonObjectType.MultiPolygon:
                    return new MultiPolygonJsonConverter().ReadJson(coordReader, typeof(MultiPolygon), geom, serializer);
                case GeoJsonObjectType.Polygon:
                    return new PolygonJsonConverter().ReadJson(coordReader, typeof(MultiPolygon), geom, serializer);
                case GeoJsonObjectType.MultiLineString:
                    return new MultiLineStringJsonConverter().ReadJson(coordReader, typeof(MultiLineString), geom, serializer);
                case GeoJsonObjectType.LineString:
                    return new LineStringJsonConverter().ReadJson(coordReader, typeof(LineString), geom, serializer);
                case GeoJsonObjectType.MultiPoint:
                    return new MultiPointJsonConverter().ReadJson(coordReader, typeof(MultiPoint), geom, serializer);
                case GeoJsonObjectType.Point:
                    return new PointJsonConverter().ReadJson(coordReader, typeof(Point), geom, serializer);
                default:
                    throw new InvalidFormatException(string.Format("Not a valid GeoSon geometry type: {0}", type));
            }
        }

        public override bool CanConvert(Type objectType) {
            return objectType == typeof(MultiPolygon) || objectType == typeof(Polygon) || objectType == typeof(MultiLineString) || objectType == typeof(LineString) || objectType == typeof(MultiPoint) || objectType == typeof(Point);
        }

        #endregion
    }
}

