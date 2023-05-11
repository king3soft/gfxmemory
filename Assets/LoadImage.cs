using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LoadImage : MonoBehaviour {

    public RawImage mImage;
    public string mBundleName;
    public string mImageName;

    private AssetBundle assetBundle;
    
    public void OnClick(BaseEventData e)
    {
        if (mImage.texture != null)
        {
            Texture texture = mImage.texture;
            mImage.texture = null;
            Resources.UnloadAsset(texture);
            assetBundle.Unload(true);
            assetBundle = null;
        }
        else
        {
            assetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, mBundleName)); 
            Texture texture = assetBundle.LoadAsset<Texture>(mImageName);
            mImage.texture = texture;
        }
    }
}
