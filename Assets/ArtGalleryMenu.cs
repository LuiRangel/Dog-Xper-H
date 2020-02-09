using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArtGalleryMenu : MonoBehaviour
{

     public GameObject asset;
     public SpriteRenderer sprite;
     public bool toggle = true;
     public Sprite[] assetList = { };

     public void back()
     {
          SceneManager.LoadScene(0);
     }
     public void nextAsset()
     {
          asset = GameObject.Find("Background");

     }

     public void prevAsset()
     {
          asset = GameObject.Find("Background");

     }

     public void toggleAnim()
     {
          if (toggle)
          {
               asset = GameObject.Find("SitAssetAnim");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = false;

               asset = GameObject.Find("WalkAssetAnim");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = false;

               asset = GameObject.Find("FocusPNG");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = false;

               asset = GameObject.Find("LayAssetAnim");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = false;

               asset = GameObject.Find("HDWalkAssetAnim");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = false;

               asset = GameObject.Find("DefaultHDPNG");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = false;

               asset = GameObject.Find("DefaultStandPNG");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = false;

               asset = GameObject.Find("DownSniffAssetAnim");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = false;

               asset = GameObject.Find("UpSniffAssetAnim");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = false;

               asset = GameObject.Find("HeadPetPNG");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = false;
               toggle = false;
          }
          else
          {
               asset = GameObject.Find("SitAssetAnim");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = true;

               asset = GameObject.Find("WalkAssetAnim");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = true;

               asset = GameObject.Find("FocusPNG");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = true;

               asset = GameObject.Find("LayAssetAnim");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = true;

               asset = GameObject.Find("HDWalkAssetAnim");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = true;

               asset = GameObject.Find("DefaultHDPNG");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = true;

               asset = GameObject.Find("DefaultStandPNG");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = true;

               asset = GameObject.Find("DownSniffAssetAnim");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = true;

               asset = GameObject.Find("UpSniffAssetAnim");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = true;

               asset = GameObject.Find("HeadPetPNG");
               sprite = asset.GetComponent<SpriteRenderer>();
               sprite.enabled = true;
               toggle = true;
          }
          
     }
}
