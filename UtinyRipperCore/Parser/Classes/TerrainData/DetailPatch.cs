﻿using System.Collections.Generic;
using UtinyRipper.AssetExporters;
using UtinyRipper.Exporter.YAML;

namespace UtinyRipper.Classes.TerrainDatas
{
	public struct DetailPatch : IAssetReadable, IYAMLExportable
	{
		public void Read(AssetStream stream)
		{
			Bounds.Read(stream);
			m_layerIndices = stream.ReadByteArray();
			m_numberOfObjects = stream.ReadByteArray();
		}

		public YAMLNode ExportYAML(IAssetsExporter exporter)
		{
			YAMLMappingNode node = new YAMLMappingNode();
			node.Add("bounds", Bounds.ExportYAML(exporter));
			node.Add("layerIndices", LayerIndices.ExportYAML());
			node.Add("numberOfObjects", NumberOfObjects.ExportYAML());
			return node;
		}

		public IReadOnlyList<byte> LayerIndices => m_layerIndices;
		public IReadOnlyList<byte> NumberOfObjects => m_numberOfObjects;

		public AABB Bounds;

		private byte[] m_layerIndices;
		private byte[] m_numberOfObjects;
	}
}
