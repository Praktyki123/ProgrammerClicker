using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PanelLvlImages : MonoBehaviour
{
    [Header("Choose Id Object")]
    [Header("Skills id = 0")]
    [Header("Room id = 1")]
    [Header("Computer id = 2")]
    [Header("Bed id = 3")]
    [Header("Desk id = 4")]
    [Header("Chair id = 5")]
    [Header("Furniture id = 6")]
    [Header("Decoration id = 7")]
    

    public int IdUpgradeObject;
    [Header("Lvl 0")]
    public Image img0;
    public Image img01;
    public int x0, y0;
    public int x01, y01;
    [Header("Lvl 1")]
    public Image img1;
    public Image img12;
    public int x1, y1;
    public int x12, y12;
    [Header("Lvl 2")]
    public Image img2;
    public Image img23;
    public int x2, y2;
    public int x23, y23;
    [Header("Lvl 3")]
    public Image img3;
    public Image img34;
    public int x3, y3;
    public int x34, y34;
    [Header("Lvl 4")]
    public Image img4;
    public Image img45;
    public int x4, y4;
    public int x45, y45;
    [Header("Lvl 5")]
    public Image img5;
    public Image img56;
    public int x5, y5;
    public int x56, y56;

    void Start()
    {
        
    }

    void Update()
    {

      
        

        if(IdUpgradeObject == 0)
        {
            
            
        }
        if(IdUpgradeObject == 1)
        {
            int ActiveObject = PlayerPrefs.GetInt("itemTwo");
            if (ActiveObject == 0)
            {
                img0.enabled = true;
                img0.transform.position = new Vector2(x0, y0);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 1)
            {
                img1.enabled = true;
                img1.transform.position = new Vector2(x1, y1);
                img0.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 2)
            {
                img2.enabled = true;
                img2.transform.position = new Vector2(x2, y2);
                img1.enabled = false;
                img0.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 3)
            {
                img3.enabled = true;
                img3.transform.position = new Vector2(x3, y3);
                img1.enabled = false;
                img2.enabled = false;
                img0.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 4)
            {
                img4.enabled = true;
                img4.transform.position = new Vector2(x4, y4);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img0.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 5)
            {
                img5.enabled = true;
                img5.transform.position = new Vector2(x5, y5);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img0.enabled = false;
            }
        }
        if(IdUpgradeObject == 2)
        {
            int ActiveObject = PlayerPrefs.GetInt("itemThree");
            if (ActiveObject == 0)
            {
                img0.enabled = true;
                img0.transform.position = new Vector2(x0, y0);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 1)
            {
                img1.enabled = true;
                img1.transform.position = new Vector2(x1, y1);
                img0.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 2)
            {
                img2.enabled = true;
                img2.transform.position = new Vector2(x2, y2);
                img1.enabled = false;
                img0.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 3)
            {
                img3.enabled = true;
                img3.transform.position = new Vector2(x3, y3);
                img1.enabled = false;
                img2.enabled = false;
                img0.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 4)
            {
                img4.enabled = true;
                img4.transform.position = new Vector2(x4, y4);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img0.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 5)
            {
                img5.enabled = true;
                img5.transform.position = new Vector2(x5, y5);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img0.enabled = false;
            }
        }
        if(IdUpgradeObject == 3)
        {
            int ActiveObject = PlayerPrefs.GetInt("itemFour");
            if (ActiveObject == 0)
            {
                img0.enabled = true;
                img0.transform.position = new Vector2(x0, y0);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 1)
            {
                img1.enabled = true;
                img1.transform.position = new Vector2(x1, y1);
                img0.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 2)
            {
                img2.enabled = true;
                img2.transform.position = new Vector2(x2, y2);
                img1.enabled = false;
                img0.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 3)
            {
                img3.enabled = true;
                img3.transform.position = new Vector2(x3, y3);
                img1.enabled = false;
                img2.enabled = false;
                img0.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 4)
            {
                img4.enabled = true;
                img4.transform.position = new Vector2(x4, y4);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img0.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 5)
            {
                img5.enabled = true;
                img5.transform.position = new Vector2(x5, y5);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img0.enabled = false;
            }

        }
        if(IdUpgradeObject == 4)
        {
            int ActiveObject = PlayerPrefs.GetInt("itemFive");
            if (ActiveObject == 0)
            {
                img0.enabled = true;
                img0.transform.position = new Vector2(x0, y0);
                img1.enabled = false;
            
                img2.enabled = false;
            
                img3.enabled = false;
                
                img4.enabled = false;
               
                img5.enabled = false;
              
            }
            if (ActiveObject == 1)
            {
                img1.enabled = true;
          
                img1.transform.position = new Vector2(x1, y1);
               
                img0.enabled = false;
           
                img2.enabled = false;
              
                img3.enabled = false;
           
                img4.enabled = false;
           
                img5.enabled = false;
               
            }
            if (ActiveObject == 2)
            {
                img2.enabled = true;
       
                img2.transform.position = new Vector2(x2, y2);
           
                img1.enabled = false;
     
                img0.enabled = false;
              
                img3.enabled = false;
              
                img4.enabled = false;
             
                img5.enabled = false;
              
            }
            if (ActiveObject == 3)
            {
                img3.enabled = true;
           
                img3.transform.position = new Vector2(x3, y3);
           
                img1.enabled = false;
 
                img0.enabled = false;
         
                img2.enabled = false;
          
                img4.enabled = false;
    
                img5.enabled = false;
   
            }
            if (ActiveObject == 4)
            {
                img4.enabled = true;
           
                img4.transform.position = new Vector2(x4, y4);
             
                img1.enabled = false;
        
                img2.enabled = false;
        
                img3.enabled = false;
        
                img0.enabled = false;
            
                img5.enabled = false;
              
            }
            if (ActiveObject == 5)
            {
                img5.enabled = true;
            
                img5.transform.position = new Vector2(x5, y5);
                img1.enabled = false;
    
                img2.enabled = false;
          
                img3.enabled = false;
           
                img0.enabled = false;
             
                img4.enabled = false;
               
            }
        }
        if(IdUpgradeObject == 5)
        {
            int ActiveObject = PlayerPrefs.GetInt("itemSix");
            if (ActiveObject == 0)
            {
                img0.enabled = true;
                img0.transform.position = new Vector2(x0, y0);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 1)
            {
                img1.enabled = true;
                img1.transform.position = new Vector2(x1, y1);
                img0.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 2)
            {
                img2.enabled = true;
                img2.transform.position = new Vector2(x2, y2);
                img1.enabled = false;
                img0.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 3)
            {
                img3.enabled = true;
                img3.transform.position = new Vector2(x3, y3);
                img1.enabled = false;
                img2.enabled = false;
                img0.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 4)
            {
                img4.enabled = true;
                img4.transform.position = new Vector2(x4, y4);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img0.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 5)
            {
                img5.enabled = true;
                img5.transform.position = new Vector2(x5, y5);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img0.enabled = false;
            }
        }
        if (IdUpgradeObject == 6)
        {
            int ActiveObject = PlayerPrefs.GetInt("itemSeven");
            if (ActiveObject == 0)
            {
                img0.enabled = true;
                img0.transform.position = new Vector2(x0, y0);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 1)
            {
                img1.enabled = true;
                img1.transform.position = new Vector2(x1, y1);
                img0.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 2)
            {
                img2.enabled = true;
                img2.transform.position = new Vector2(x2, y2);
                img1.enabled = false;
                img0.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 3)
            {
                img3.enabled = true;
                img3.transform.position = new Vector2(x3, y3);
                img1.enabled = false;
                img2.enabled = false;
                img0.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 4)
            {
                img4.enabled = true;
                img4.transform.position = new Vector2(x4, y4);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img0.enabled = false;
                img5.enabled = false;
            }
            if (ActiveObject == 5)
            {
                img5.enabled = true;
                img5.transform.position = new Vector2(x5, y5);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img0.enabled = false;
            }
        }

    }
}
