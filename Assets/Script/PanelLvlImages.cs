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
    public Image img0_1;
    public Image img0_2;
    public Image img0_3;
    public int x0, y0;
    public int x0_1, y0_1;
    public int x0_2, y0_2;
    public int x0_3, y0_3;
    [Header("Lvl 1")]
    public Image img1;
    public Image img1_2;
    public Image img1_3;
    public Image img1_4;
    public int x1, y1;
    public int x1_2, y1_2;
    public int x1_3, y1_3;
    public int x1_4, y1_4;
    [Header("Lvl 2")]
    public Image img2;
    public Image img2_3;
    public Image img2_4;
    public Image img2_5;
    public Image img2_6;
    public int x2, y2;
    public int x2_3, y2_3; 
    public int x2_4, y2_4;
    public int x2_5, y2_5;
    public int x2_6, y2_6;
    [Header("Lvl 3")]
    public Image img3;
    public Image img3_4;
    public Image img3_5;
    public Image img3_6;
    public Image img3_7;
    public int x3, y3;
    public int x3_4, y3_4;
    public int x3_5, y3_5;
    public int x3_6, y3_6;
    public int x3_7, y3_7;
    [Header("Lvl 4")]
    public Image img4;
    public Image img4_5;
    public Image img4_6;
    public Image img4_7;
    public Image img4_8;
    public Image img4_9;
    public int x4, y4;
    public int x4_5, y4_5;
    public int x4_6, y4_6;
    public int x4_7, y4_7;
    public int x4_8, y4_8;
    public int x4_9, y4_9;
    [Header("Lvl 5")]
    public Image img5;
    public Image img5_6;
    public Image img5_7;
    public Image img5_8;
    public Image img5_9;
    public Image img5_1;
    public Image img5_2;
    public int x5, y5;
    public int x5_6, y5_6;
    public int x5_7, y5_7;
    public int x5_8, y5_8;
    public int x5_9, y5_9;
    public int x5_1, y5_1;
    public int x5_2, y5_2;

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
                img0_1.enabled = true;
                img0.transform.position = new Vector2(x0, y0);
                img0_1.transform.position = new Vector2(x0_1, y0_1);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img3_4.enabled = false;
                img4_5.enabled = false;
                img5.enabled = false;
                img5_6.enabled = false;
                img1_2.enabled = false;
                img2_3.enabled = false;
            }
            if (ActiveObject == 1)
            {
                img1.enabled = true;
                img1_2.enabled = true;
                img1.transform.position = new Vector2(x1, y1);
                img1_2.transform.position = new Vector2(x1_2, y1_2);
                img0.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
                img4_5.enabled = false;
                img2_3.enabled = false;
                img5_6.enabled = false;
                img0_1.enabled = false;
                img3_4.enabled = false;
            }
            if (ActiveObject == 2)
            {
                img2.enabled = true;
                img2_3.enabled = true;
                img2.transform.position = new Vector2(x2, y2);
                img2_3.transform.position = new Vector2(x2_3, y2_3);
                img1.enabled = false;
                img0.enabled = false;
                img3.enabled = false;
                img1_2.enabled = false;
                img4.enabled = false;
                img5_6.enabled = false;
                img5.enabled = false;
                img4_5.enabled = false;
                img0_1.enabled = false;
                img3_4.enabled = false;
            }
            if (ActiveObject == 3)
            {
                img3.enabled = true;
                img3_4.enabled = true;
                img3.transform.position = new Vector2(x3, y3);
                img3_4.transform.position = new Vector2(x3_4, y3_4);
                img1.enabled = false;
                img2.enabled = false;
                img1_2.enabled = false;
                img0.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
                img2_3.enabled = false;
                img5_6.enabled = false;
                img0_1.enabled = false;
                img4_5.enabled = false;
            }
            if (ActiveObject == 4)
            {
                img4.enabled = true;
                img4_5.enabled = true;
                img4.transform.position = new Vector2(x4, y4);
                img4_5.transform.position = new Vector2(x4_5, y4_5);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img0.enabled = false;
                img5.enabled = false;
                img3_4.enabled = false;
                img0_1.enabled = false;
                img2_3.enabled = false;
                img1_2.enabled = false;
                img5_6.enabled = false;
            }
            if (ActiveObject == 5)
            {
                img5.enabled = true;
                img5_6.enabled = true;
                img5.transform.position = new Vector2(x5, y5);
                img5_6.transform.position = new Vector2(x5_6, y5_6);
                img1.enabled = false;
                img2_3.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img0_1.enabled = false;
                img4.enabled = false;
                img3_4.enabled = false;
                img0.enabled = false;
                img1_2.enabled = false;
                img4_5.enabled = false;
            }
        }
        if(IdUpgradeObject == 2)
        {
            int ActiveObject = PlayerPrefs.GetInt("itemThree");
            if (ActiveObject == 0)
            {
                img0.enabled = true;
                img0_1.enabled = true;
                img0_2.enabled = true;
                img0_3.enabled = true;
                img0.transform.position = new Vector2(x0, y0);
                img0_1.transform.position = new Vector2(x0_1, y0_1);
                img0_2.transform.position = new Vector2(x0_2, y0_2);
                img0_3.transform.position = new Vector2(x0_3, y0_3);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
                img1_2.enabled = false;
                img1_3.enabled = false;
                img1_4.enabled = false;
                img2_3.enabled = false;
                img2_4.enabled = false;
                img2_5.enabled = false;
                img3_4.enabled = false;
                img3_5.enabled = false;
                img3_6.enabled = false;
                img4_5.enabled = false;
                img4_6.enabled = false;
                img4_7.enabled = false;
                img5_6.enabled = false;
                img5_7.enabled = false;
                img5_8.enabled = false;
                img3_7.enabled = false;
                img4_8.enabled = false;
                img4_9.enabled = false;
                img5_9.enabled = false;
            }
            if (ActiveObject == 1)
            {
                img1.enabled = true;
                img1_2.enabled = true;
                img1_3.enabled = true;
                img1_4.enabled = true;
                img1.transform.position = new Vector2(x1, y1);
                img1_2.transform.position = new Vector2(x1_2, y1_2);
                img1_3.transform.position = new Vector2(x1_3, y1_3);
                img1_4.transform.position = new Vector2(x1_4, y1_4);
                img0.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
                img0_1.enabled = false;
                img0_2.enabled = false;
                img0_3.enabled = false;
                img2_3.enabled = false;
                img2_4.enabled = false;
                img2_5.enabled = false;
                img3_4.enabled = false;
                img3_5.enabled = false;
                img3_6.enabled = false;
                img4_5.enabled = false;
                img4_6.enabled = false;
                img4_7.enabled = false;
                img5_6.enabled = false;
                img5_7.enabled = false;
                img5_8.enabled = false;
                img3_7.enabled = false;
                img4_8.enabled = false;
                img4_9.enabled = false;
                img5_9.enabled = false;
            }
            if (ActiveObject == 2)
            {
                img2.enabled = true;
                img2_3.enabled = true;
                img2_4.enabled = true;
                img2_5.enabled = true;
                img2.transform.position = new Vector2(x2, y2);
                img2_3.transform.position = new Vector2(x2_3, y2_3);
                img2_4.transform.position = new Vector2(x2_4, y2_4);
                img2_5.transform.position = new Vector2(x2_5, y2_5);
                img1.enabled = false;
                img0.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
                img0_1.enabled = false;
                img0_2.enabled = false;
                img0_3.enabled = false;
                img1_2.enabled = false;
                img1_3.enabled = false;
                img1_4.enabled = false;
                img3_4.enabled = false;
                img3_5.enabled = false;
                img3_6.enabled = false;
                img4_5.enabled = false;
                img4_6.enabled = false;
                img4_7.enabled = false;
                img5_6.enabled = false;
                img5_7.enabled = false;
                img5_8.enabled = false;
                img3_7.enabled = false;
                img4_8.enabled = false;
                img4_9.enabled = false;
                img5_9.enabled = false;
            }
            if (ActiveObject == 3)
            {
                img3.enabled = true;
                img3_4.enabled = true;
                img3_5.enabled = true;
                img3_6.enabled = true;
                img3_7.enabled = true;
                img3.transform.position = new Vector2(x3, y3);
                img3_4.transform.position = new Vector2(x3_4, y3_4);
                img3_5.transform.position = new Vector2(x3_5, y3_5);
                img3_6.transform.position = new Vector2(x3_6, y3_6);
                img3_7.transform.position = new Vector2(x3_7, y3_7);
                img1.enabled = false;
                img2.enabled = false;
                img0.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
                img0_1.enabled = false;
                img0_2.enabled = false;
                img0_3.enabled = false;
                img1_2.enabled = false;
                img1_3.enabled = false;
                img1_4.enabled = false;
                img2_3.enabled = false;
                img2_4.enabled = false;
                img2_5.enabled = false;
                img4_5.enabled = false;
                img4_6.enabled = false;
                img4_7.enabled = false;
                img5_6.enabled = false;
                img5_7.enabled = false;
                img5_8.enabled = false;
                img4_8.enabled = false;
                img4_9.enabled = false;
                img5_9.enabled = false;
            }
            if (ActiveObject == 4)
            {
                img4.enabled = true;
                img4_5.enabled = true;
                img4_6.enabled = true;
                img4_7.enabled = true;
                img4_8.enabled = true;
                img4_9.enabled = true;
                img4.transform.position = new Vector2(x4, y4);
                img4_5.transform.position = new Vector2(x4_5, y4_5);
                img4_6.transform.position = new Vector2(x4_6, y4_6);
                img4_7.transform.position = new Vector2(x4_7, y4_7);
                img4_8.transform.position = new Vector2(x4_8, y4_8);
                img4_9.transform.position = new Vector2(x4_9, y4_9);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img0.enabled = false;
                img5.enabled = false;
                img0_1.enabled = false;
                img0_2.enabled = false;
                img0_3.enabled = false;
                img1_2.enabled = false;
                img1_3.enabled = false;
                img1_4.enabled = false;
                img2_3.enabled = false;
                img2_4.enabled = false;
                img2_5.enabled = false;
                img3_4.enabled = false;
                img3_5.enabled = false;
                img3_6.enabled = false;
                img5_6.enabled = false;
                img5_7.enabled = false;
                img5_8.enabled = false;
                img3_7.enabled = false;
                img5_9.enabled = false;
            }
            if (ActiveObject == 5)
            {
                img5.enabled = true;
                img5_6.enabled = true;
                img5_7.enabled = true;
                img5_8.enabled = true;
                img5_9.enabled = true;
                img5.transform.position = new Vector2(x5, y5);
                img5_6.transform.position = new Vector2(x5_6, y5_6);
                img5_7.transform.position = new Vector2(x5_7, y5_7);
                img5_8.transform.position = new Vector2(x5_8, y5_8);
                img5_9.transform.position = new Vector2(x5_9, y5_9);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img0.enabled = false;
                img0_1.enabled = false;
                img0_2.enabled = false;
                img0_3.enabled = false;
                img1_2.enabled = false;
                img1_3.enabled = false;
                img1_4.enabled = false;
                img2_3.enabled = false;
                img2_4.enabled = false;
                img2_5.enabled = false;
                img3_4.enabled = false;
                img3_5.enabled = false;
                img3_6.enabled = false;
                img4_5.enabled = false;
                img4_6.enabled = false;
                img4_7.enabled = false;
                img3_7.enabled = false;
                img4_8.enabled = false;
                img4_9.enabled = false;
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
                img0_1.enabled = true;
                img0_2.enabled = true;
                img0_3.enabled = true;
                img0.transform.position = new Vector2(x0, y0);
                img0_1.transform.position = new Vector2(x0_1, y0_1);
                img0_2.transform.position = new Vector2(x0_2, y0_2);
                img0_3.transform.position = new Vector2(x0_3, y0_3);
                img1.enabled = false;
                img1_2.enabled = false;
                img2.enabled = false;
                img3_6.enabled = false;
                img2_3.enabled = false;
                img2_4.enabled = false;
                img3.enabled = false;
                img3_4.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
                img4_5.enabled = false;
                img4_7.enabled = false;
                img5_7.enabled = false;  
                img4_6.enabled = false;
                img3_5.enabled = false;
                img5_8.enabled = false;
                img5_6.enabled = false;
                img1_3.enabled = false;
                img1_4.enabled = false;
                img2_5.enabled = false;
                img4_8.enabled = false;
                img5_9.enabled = false;
                img3_7.enabled = false;
                img2_6.enabled = false;
            }
            if (ActiveObject == 1)
            {
                img1.enabled = true;
                img1_2.enabled = true;
                img1_3.enabled = true;
                img1_4.enabled = true;
                img1.transform.position = new Vector2(x1, y1);
                img1_2.transform.position = new Vector2(x1_2, y1_2);
                img1_3.transform.position = new Vector2(x1_3, y1_3);
                img1_4.transform.position = new Vector2(x1_4, y1_4);
                img0.enabled = false;
                img0_1.enabled = false;
                img2.enabled = false;
                img5_8.enabled = false;
                img2_3.enabled = false;
                img3.enabled = false;
                img4_7.enabled = false;
                img4_5.enabled = false;
                img4.enabled = false;
                img2_4.enabled = false;
                img3_6.enabled = false;
                img3_5.enabled = false;
                img3_4.enabled = false;
                img5.enabled = false;
                img5_6.enabled = false;
                img4_6.enabled = false;
                img0_2.enabled = false;
                img5_7.enabled = false;
                img0_3.enabled = false;
                img2_5.enabled = false;
                img4_8.enabled = false;
                img5_9.enabled = false;
                img3_7.enabled = false;
                img2_6.enabled = false;
            }
            if (ActiveObject == 2)
            {
                img2.enabled = true;
                img2_3.enabled = true;
                img2_4.enabled = true;
                img2_5.enabled = true;
                img2_6.enabled = true;
                img2.transform.position = new Vector2(x2, y2);
                img2_3.transform.position = new Vector2(x2_3, y2_3);
                img2_4.transform.position = new Vector2(x2_4, y2_4);
                img2_5.transform.position = new Vector2(x2_5, y2_5);
                img2_6.transform.position = new Vector2(x2_6, y2_6);
                img1.enabled = false;
                img1_2.enabled = false;
                img0.enabled = false;
                img4_5.enabled = false;
                img0_1.enabled = false;
                img3_4.enabled = false;
                img3.enabled = false;
                img1_3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
                img5_8.enabled = false;
                img5_6.enabled = false;
                img0_2.enabled = false;
                img5_7.enabled = false;
                img3_6.enabled = false;
                img4_7.enabled = false;
                img4_6.enabled = false;
                img3_5.enabled = false;
                img0_3.enabled = false;
                img1_4.enabled = false;
                img4_8.enabled = false;
                img5_9.enabled = false;
                img3_7.enabled = false;
            }
            if (ActiveObject == 3)
            {
                img3.enabled = true;
                img3_4.enabled = true;
                img3_5.enabled = true;
                img3_6.enabled = true;
                img3_7.enabled = true;
                img3.transform.position = new Vector2(x3, y3);
                img3_4.transform.position = new Vector2(x3_4, y3_4);
                img3_5.transform.position = new Vector2(x3_5, y3_5);
                img3_6.transform.position = new Vector2(x3_6, y3_6);
                img3_7.transform.position = new Vector2(x3_7, y3_7);
                img1.enabled = false;
                img1_2.enabled = false;
                img2.enabled = false;
                img0.enabled = false;
                img0_1.enabled = false;
                img4_5.enabled = false;
                img4_6.enabled = false;
                img4.enabled = false;
                img5.enabled = false; 
                img2_4.enabled = false;
                img2_3.enabled = false;
                img1_3.enabled = false;
                img5_7.enabled = false;
                img5_6.enabled = false;
                img0_2.enabled = false;
                img5_8.enabled = false;
                img4_7.enabled = false;
                img0_3.enabled = false;
                img1_4.enabled = false;
                img2_5.enabled = false;
                img4_8.enabled = false;
                img5_9.enabled = false;
                img2_6.enabled = false;
            }
            if (ActiveObject == 4)
            {
                img4.enabled = true;
                img4_5.enabled = true;
                img4_6.enabled = true;
                img4_7.enabled = true;
                img4_8.enabled = true;
                img4_6.transform.position = new Vector2(x4_6, y4_6);
                img4_5.transform.position = new Vector2(x4_5, y4_5);
                img4.transform.position = new Vector2(x4, y4);
                img4_7.transform.position = new Vector2(x4_7, y4_7);
                img4_8.transform.position = new Vector2(x4_8, y4_8);
                img1.enabled = false;
                img1_2.enabled = false;
                img2.enabled = false;
                img1_3.enabled = false;
                img2_4.enabled = false;
                img3_6.enabled = false;
                img3.enabled = false;
                img3_4.enabled = false;
                img0.enabled = false;
                img0_1.enabled = false;
                img5.enabled = false;
                img2_3.enabled = false;
                img3_5.enabled = false;
                img5_6.enabled = false;
                img0_2.enabled = false;
                img5_7.enabled = false;
                img5_8.enabled = false;
                img0_3.enabled = false;
                img1_4.enabled = false;
                img2_5.enabled = false;
                img5_9.enabled = false;
                img3_7.enabled = false;
                img2_6.enabled = false;
            }
            if (ActiveObject == 5)
            {
                img5.enabled = true;
                img5_6.enabled = true;
                img5_7.enabled = true;
                img5_8.enabled = true;
                img5_9.enabled = true;
                img5.transform.position = new Vector2(x5, y5);
                img5_6.transform.position = new Vector2(x5_6, y5_6);
                img5_7.transform.position = new Vector2(x5_7, y5_7);
                img5_8.transform.position = new Vector2(x5_8, y5_8);
                img5_9.transform.position = new Vector2(x5_9, y5_9);
                img1.enabled = false;
                img1_2.enabled = false;
                img2.enabled = false;
                img2_3.enabled = false;
                img3.enabled = false;
                img3_4.enabled = false;
                img4.enabled = false;
                img4_5.enabled = false;
                img3_6.enabled = false;
                img2_4.enabled = false;
                img1_3.enabled = false;
                img0.enabled = false;
                img0_1.enabled = false;
                img4_7.enabled = false;
                img4_6.enabled = false;
                img3_5.enabled = false;
                img0_2.enabled = false;
                img0_3.enabled = false;
                img1_4.enabled = false;
                img2_5.enabled = false;
                img4_8.enabled = false;
                img3_7.enabled = false;
                img2_6.enabled = false;

            }
        }
        if (IdUpgradeObject == 7)
        {
            int ActiveObject = PlayerPrefs.GetInt("itemEight");
            if (ActiveObject == 0)
            {
                img0.enabled = true;
                img0.transform.position = new Vector2(x0, y0);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
                img3_4.enabled = false;
                img3_5.enabled = false;
                img3_6.enabled = false;
                img4_5.enabled = false;
                img4_6.enabled = false;
                img4_7.enabled = false;
                img4_8.enabled = false;
                img5_6.enabled = false;
                img5_7.enabled = false;
                img5_8.enabled = false;
                img5_9.enabled = false;
                img5_1.enabled = false;
                img5_2.enabled = false;
                img2_6.enabled = false;
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
                img3_4.enabled = false;
                img3_5.enabled = false;
                img3_6.enabled = false;
                img4_5.enabled = false;
                img4_6.enabled = false;
                img4_7.enabled = false;
                img4_8.enabled = false;
                img5_6.enabled = false;
                img5_7.enabled = false;
                img5_8.enabled = false;
                img5_9.enabled = false;
                img5_1.enabled = false;
                img5_2.enabled = false;
                img2_6.enabled = false;
            }
            if (ActiveObject == 2)
            {
                img2.enabled = true;
                img2_6.enabled = true;
                img2.transform.position = new Vector2(x2, y2);
                img2_6.transform.position = new Vector2(x2_6, y2_6);
                img1.enabled = false;
                img0.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
                img3_4.enabled = false;
                img3_5.enabled = false;
                img3_6.enabled = false;
                img4_5.enabled = false;
                img4_6.enabled = false;
                img4_7.enabled = false;
                img4_8.enabled = false;
                img5_6.enabled = false;
                img5_7.enabled = false;
                img5_8.enabled = false;
                img5_9.enabled = false;
                img5_1.enabled = false;
                img5_2.enabled = false;
            }
            if (ActiveObject == 3)
            {
                img3.enabled = true;
                img3_4.enabled = true;
                img3_5.enabled = true;
                img3_6.enabled = true;
                img3.transform.position = new Vector2(x3, y3);
                img3_4.transform.position = new Vector2(x3_4, y3_4);
                img3_5.transform.position = new Vector2(x3_5, y3_5);
                img3_6.transform.position = new Vector2(x3_6, y3_6);
                img1.enabled = false;
                img2.enabled = false;
                img0.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
                img4_5.enabled = false;
                img4_6.enabled = false;
                img4_7.enabled = false;
                img4_8.enabled = false;
                img5_6.enabled = false;
                img5_7.enabled = false;
                img5_8.enabled = false;
                img5_9.enabled = false;
                img5_1.enabled = false;
                img5_2.enabled = false;
                img2_6.enabled = false;
            }
            if (ActiveObject == 4)
            {
                img4.enabled = true;
                img4_5.enabled = true;
                img4_6.enabled = true;
                img4_7.enabled = true;
                img4_8.enabled = true;
                img4.transform.position = new Vector2(x4, y4);
                img4_5.transform.position = new Vector2(x4_5, y4_5);
                img4_6.transform.position = new Vector2(x4_6, y4_6);
                img4_7.transform.position = new Vector2(x4_7, y4_7);
                img4_8.transform.position = new Vector2(x4_8, y4_8);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img0.enabled = false;
                img5.enabled = false;
                img3_4.enabled = false;
                img3_5.enabled = false;
                img3_6.enabled = false;
                img5_6.enabled = false;
                img5_7.enabled = false;
                img5_8.enabled = false;
                img5_9.enabled = false;
                img5_1.enabled = false;
                img5_2.enabled = false;
                img2_6.enabled = false;
            }
            if (ActiveObject == 5)
            {
                img5.enabled = true;
                img5_6.enabled = true;
                img5_7.enabled = true;
                img5_8.enabled = true;
                img5_9.enabled = true;
                img5_1.enabled = true;
                img5_2.enabled = true;
                img5.transform.position = new Vector2(x5, y5);
                img5_6.transform.position = new Vector2(x5_6, y5_6);
                img5_7.transform.position = new Vector2(x5_7, y5_7);
                img5_8.transform.position = new Vector2(x5_8, y5_8);
                img5_9.transform.position = new Vector2(x5_9, y5_9);
                img5_1.transform.position = new Vector2(x5_1, y5_1);
                img5_2.transform.position = new Vector2(x5_2, y5_2);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img0.enabled = false;
                img3_4.enabled = false;
                img3_5.enabled = false;
                img3_6.enabled = false;
                img4_5.enabled = false;
                img4_6.enabled = false;
                img4_7.enabled = false;
                img4_8.enabled = false;
                img2_6.enabled = false;
            }
        }
    }
}
