using System.IO;
using UnityEditor;

public static class AssetBundlePacker
{
    [MenuItem("Assets/Build AssetBundle(Windows)")]
    static void BuildAssetBundle_Windows()
    {
        string outputPath = "AssetBundles";
        if (!Directory.Exists(outputPath))
        {
            Directory.CreateDirectory(outputPath);
        }
        BuildPipeline.BuildAssetBundles(outputPath, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
    }
    
    
    [MenuItem("Assets/Build AssetBundle(Mac)")]
    static void BuildAssetBundle_Mac()
    {
        string outputPath = "AssetBundles";
        if (!Directory.Exists(outputPath))
        {
            Directory.CreateDirectory(outputPath);
        }
        BuildPipeline.BuildAssetBundles(outputPath, BuildAssetBundleOptions.None, BuildTarget.StandaloneOSX);
    }
    
    [MenuItem("Assets/Build AssetBundle(IOS)")]
    static void BuildAssetBundle_IOS()
    {
        string outputPath = "AssetBundles";
        if (!Directory.Exists(outputPath))
        {
            Directory.CreateDirectory(outputPath);
        }
        BuildPipeline.BuildAssetBundles(outputPath, BuildAssetBundleOptions.None, BuildTarget.iOS);
    }
}