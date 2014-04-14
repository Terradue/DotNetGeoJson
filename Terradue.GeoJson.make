

# Warning: This is an automatically generated file, do not edit!

srcdir=.
top_srcdir=.

include $(top_srcdir)/config.make

ifeq ($(CONFIG),DEBUG)
ASSEMBLY_COMPILER_COMMAND = dmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize- -debug "-define:DEBUG;"
ASSEMBLY = bin/Debug/Terradue.GeoJson.dll
ASSEMBLY_MDB = $(ASSEMBLY).mdb
COMPILE_TARGET = library
PROJECT_REFERENCES = 
BUILD_DIR = bin/Debug

TERRADUE_GEOJSON_DLL_MDB_SOURCE=bin/Debug/Terradue.GeoJson.dll.mdb
TERRADUE_GEOJSON_DLL_MDB=$(BUILD_DIR)/Terradue.GeoJson.dll.mdb
SERVICESTACK_TEXT_DLL_SOURCE=packages/ServiceStack.Text.3.9.71/lib/net35/ServiceStack.Text.dll

endif

ifeq ($(CONFIG),RELEASE)
ASSEMBLY_COMPILER_COMMAND = dmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize+
ASSEMBLY = bin/Release/Terradue.GeoJson.dll
ASSEMBLY_MDB = 
COMPILE_TARGET = library
PROJECT_REFERENCES = 
BUILD_DIR = bin/Release

TERRADUE_GEOJSON_DLL_MDB=
SERVICESTACK_TEXT_DLL_SOURCE=packages/ServiceStack.Text.3.9.71/lib/net35/ServiceStack.Text.dll

endif

AL=al
SATELLITE_ASSEMBLY_NAME=$(notdir $(basename $(ASSEMBLY))).resources.dll

PROGRAMFILES = \
	$(TERRADUE_GEOJSON_DLL_MDB) \
	$(SERVICESTACK_TEXT_DLL)  

LINUX_PKGCONFIG = \
	$(TERRADUE_GEOJSON_PC)  


RESGEN=resgen2

SERVICESTACK_TEXT_DLL = $(BUILD_DIR)/ServiceStack.Text.dll
TERRADUE_GEOJSON_PC = $(BUILD_DIR)/terradue.geojson.pc

FILES = \
	Properties/AssemblyInfo.cs \
	Terradue/GeoJson/IGeoJsonObject.cs \
	Terradue/GeoJson/GeoJsonObject.cs \
	Terradue/GeoJson/GeoJsonObjectType.cs \
	Terradue/GeoJson/CoordinateReferenceSystem/CRSBase.cs \
	Terradue/GeoJson/CoordinateReferenceSystem/CRSType.cs \
	Terradue/GeoJson/CoordinateReferenceSystem/ICRSObject.cs \
	Terradue/GeoJson/CoordinateReferenceSystem/LinkedCRS.cs \
	Terradue/GeoJson/CoordinateReferenceSystem/NamedCRS.cs \
	Terradue/GeoJson/Feature/Feature.cs \
	Terradue/GeoJson/Feature/FeatureCollection.cs \
	Terradue/GeoJson/Feature/LineStringFeature.cs \
	Terradue/GeoJson/Feature/MultiLineStringFeature.cs \
	Terradue/GeoJson/Feature/MultiPointFeature.cs \
	Terradue/GeoJson/Feature/NoGeometryFeature.cs \
	Terradue/GeoJson/Feature/PointFeature.cs \
	Terradue/GeoJson/Feature/MultiPolygonFeature.cs \
	Terradue/GeoJson/Feature/PolygonFeature.cs \
	Terradue/GeoJson/Geometry/GeographicPosition.cs \
	Terradue/GeoJson/Geometry/GeometryCollection.cs \
	Terradue/GeoJson/Geometry/GeometryFactory.cs \
	Terradue/GeoJson/Geometry/LineString.cs \
	Terradue/GeoJson/Geometry/MultiPolygon.cs \
	Terradue/GeoJson/Geometry/GeometryObject.cs \
	Terradue/GeoJson/Geometry/IGeometryObject.cs \
	Terradue/GeoJson/Geometry/IPosition.cs \
	Terradue/GeoJson/Geometry/MultiLineString.cs \
	Terradue/GeoJson/Geometry/MultiPoint.cs \
	Terradue/GeoJson/Geometry/Point.cs \
	Terradue/GeoJson/Geometry/Polygon.cs \
	Terradue/GeoJson/Geometry/Position.cs \
	Terradue/GeoJson/Geometry/ProjectedPosition.cs 

DATA_FILES = 

RESOURCES = 

EXTRAS = \
	Terradue \
	Terradue/GeoJson \
	Terradue/GeoJson/CoordinateReferenceSystem \
	Terradue/GeoJson/Feature \
	Terradue/GeoJson/Geometry \
	packages.config \
	terradue.geojson.pc.in 

REFERENCES =  \
	System \
	System.Xml \
	System.Runtime.Serialization \
	System.ServiceModel \
	System.Core

DLL_REFERENCES =  \
	packages/ServiceStack.Text.3.9.71/lib/net35/ServiceStack.Text.dll

CLEANFILES = $(PROGRAMFILES) $(LINUX_PKGCONFIG) 

#Targets
all-local: $(ASSEMBLY) $(PROGRAMFILES) $(LINUX_PKGCONFIG)  $(top_srcdir)/config.make



$(eval $(call emit-deploy-target,SERVICESTACK_TEXT_DLL))
$(eval $(call emit-deploy-wrapper,TERRADUE_GEOJSON_PC,terradue.geojson.pc))


$(eval $(call emit_resgen_targets))
$(build_xamlg_list): %.xaml.g.cs: %.xaml
	xamlg '$<'


$(ASSEMBLY_MDB): $(ASSEMBLY)
$(ASSEMBLY): $(build_sources) $(build_resources) $(build_datafiles) $(DLL_REFERENCES) $(PROJECT_REFERENCES) $(build_xamlg_list) $(build_satellite_assembly_list)
	make pre-all-local-hook prefix=$(prefix)
	mkdir -p $(shell dirname $(ASSEMBLY))
	make $(CONFIG)_BeforeBuild
	$(ASSEMBLY_COMPILER_COMMAND) $(ASSEMBLY_COMPILER_FLAGS) -out:$(ASSEMBLY) -target:$(COMPILE_TARGET) $(build_sources_embed) $(build_resources_embed) $(build_references_ref)
	make $(CONFIG)_AfterBuild
	make post-all-local-hook prefix=$(prefix)

install-local: $(ASSEMBLY) $(ASSEMBLY_MDB)
	make pre-install-local-hook prefix=$(prefix)
	make install-satellite-assemblies prefix=$(prefix)
	mkdir -p '$(DESTDIR)$(libdir)/$(PACKAGE)'
	$(call cp,$(ASSEMBLY),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call cp,$(ASSEMBLY_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call cp,$(TERRADUE_GEOJSON_DLL_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call cp,$(SERVICESTACK_TEXT_DLL),$(DESTDIR)$(libdir)/$(PACKAGE))
	mkdir -p '$(DESTDIR)$(libdir)/pkgconfig'
	$(call cp,$(TERRADUE_GEOJSON_PC),$(DESTDIR)$(libdir)/pkgconfig)
	make post-install-local-hook prefix=$(prefix)

uninstall-local: $(ASSEMBLY) $(ASSEMBLY_MDB)
	make pre-uninstall-local-hook prefix=$(prefix)
	make uninstall-satellite-assemblies prefix=$(prefix)
	$(call rm,$(ASSEMBLY),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(ASSEMBLY_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(TERRADUE_GEOJSON_DLL_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(SERVICESTACK_TEXT_DLL),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(TERRADUE_GEOJSON_PC),$(DESTDIR)$(libdir)/pkgconfig)
	make post-uninstall-local-hook prefix=$(prefix)
