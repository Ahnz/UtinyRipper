﻿using uTinyRipper.Converters;
using uTinyRipper.YAML;

namespace uTinyRipper.Classes
{
	public abstract class Behaviour : Component
	{
		protected Behaviour(AssetInfo assetInfo):
			base(assetInfo)
		{
		}

		/// <summary>
		/// 2.1.0 and greater
		/// </summary>
		private static bool IsAlign(Version version) => version.IsGreaterEqual(2, 1);

		public override void Read(AssetReader reader)
		{
			base.Read(reader);

			Enabled = reader.ReadByte();
			if (IsAlign(reader.Version))
			{
				reader.AlignStream(AlignType.Align4);
			}
		}

		public override void Write(AssetWriter writer)
		{
			base.Write(writer);

			writer.Write(Enabled);
			if (IsAlign(writer.Version))
			{
				writer.AlignStream(AlignType.Align4);
			}
		}

		protected override YAMLMappingNode ExportYAMLRoot(IExportContainer container)
		{
			YAMLMappingNode node = base.ExportYAMLRoot(container);
			node.Add(EnabledName, Enabled);
			return node;
		}

		protected void ReadComponent(AssetReader reader)
		{
			base.Read(reader);
		}

		protected void WriteComponent(AssetWriter writer)
		{
			base.Write(writer);
		}

		public const string EnabledName = "m_Enabled";

		// bool has been replaced by byte in 3.0.0
		public bool EnabledBool
		{
			get => Enabled != 0;
			set => Enabled = value ? (byte)1 : (byte)0;
		}

		public byte Enabled { get; set; }
	}
}
