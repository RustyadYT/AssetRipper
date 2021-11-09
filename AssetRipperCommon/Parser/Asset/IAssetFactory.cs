﻿using AssetRipper.Core.Interfaces;
using AssetRipper.Core.IO.Asset;
using System;

namespace AssetRipper.Core.Parser.Asset
{
	public interface IAssetFactory
	{
		IUnityObjectBase CreateAsset(AssetInfo assetInfo);
		IAsset CreateEngineAsset(string name);
		void OverrideInstantiator(ClassIDType classType, Func<AssetInfo, IUnityObjectBase> instantiator);
	}
}