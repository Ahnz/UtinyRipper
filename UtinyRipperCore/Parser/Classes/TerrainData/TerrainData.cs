﻿using UtinyRipper.AssetExporters;
using UtinyRipper.Classes.TerrainDatas;
using UtinyRipper.Exporter.YAML;

namespace UtinyRipper.Classes
{
	public sealed class TerrainData : NamedObject
	{
		public TerrainData(AssetInfo assetInfo):
			base(assetInfo)
		{
		}

		/// <summary>
		/// Less than 3.0.0
		/// </summary>
		public static bool IsReadLightmap(Version version)
		{
			return version.IsLess(3);
		}

		public override void Read(AssetStream stream)
		{
			base.Read(stream);

			SplatDatabase.Read(stream);
			DetailDatabase.Read(stream);
			Heightmap.Read(stream);
			if (IsReadLightmap(stream.Version))
			{
				Lightmap.Read(stream);
			}
		}

		protected override YAMLMappingNode ExportYAMLRoot(IAssetsExporter exporter)
		{
#warning TODO: values acording to read version (current 2017.3.0f3)
			YAMLMappingNode node = base.ExportYAMLRoot(exporter);
			node.Add("m_SplatDatabase", SplatDatabase.ExportYAML(exporter));
			node.Add("m_DetailDatabase", DetailDatabase.ExportYAML(exporter));
			node.Add("m_Heightmap", Heightmap.ExportYAML(exporter));
			return node;
		}

		public SplatDatabase SplatDatabase;
		public DetailDatabase DetailDatabase;
		public Heightmap Heightmap;
		public PPtr<Texture2D> Lightmap;
	}
}
