using UnityEngine;
using UnityEngine.Profiling;
public static class RescoureManger
{
    private static AssetBundle bundle;
    
    public static UnityEngine.Object Load(string name, System.Type type)
    {
        Profiler.BeginSample("RescoureManger.Load");
        if (bundle == null)
        {
            bundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/test");
        }
        UnityEngine.Object asset = bundle.LoadAsset(name,type);
        Profiler.EndSample();
        return asset;
    }
}
