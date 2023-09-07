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
    public Image img012;
    public Image img0123;
    public int x0, y0;
    public int x01, y01;
    public int x012, y012;
    public int x0123, y0123;
    [Header("Lvl 1")]
    public Image img1;
    public Image img12;
    public Image img123;
    public Image img1234;
    public int x1, y1;
    public int x12, y12;
    public int x123, y123;
    public int x1234, y1234;
    [Header("Lvl 2")]
    public Image img2;
    public Image img23;
    public Image img234;
    public Image img2345;
    public Image img23456;
    public int x2, y2;
    public int x23, y23; 
    public int x234, y234;
    public int x2345, y2345;
    public int x23456, y23456;
    [Header("Lvl 3")]
    public Image img3;
    public Image img34;
    public Image img345;
    public Image img3456;
    public Image img34567;
    public int x3, y3;
    public int x34, y34;
    public int x345, y345;
    public int x3456, y3456;
    public int x34567, y34567;
    [Header("Lvl 4")]
    public Image img4;
    public Image img45;
    public Image img456;
    public Image img4567;
    public Image img45678;
    public int x4, y4;
    public int x45, y45;
    public int x456, y456;
    public int x4567, y4567;
    public int x45678, y45678;
    [Header("Lvl 5")]
    public Image img5;
    public Image img56;
    public Image img567;
    public Image img5678;
    public Image img56789;
    public int x5, y5;
    public int x56, y56;
    public int x567, y567;
    public int x5678, y5678;
    public int x56789, y56789;

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
                img01.enabled = true;
                img0.transform.position = new Vector2(x0, y0);
                img01.transform.position = new Vector2(x01, y01);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img34.enabled = false;
                img45.enabled = false;
                img5.enabled = false;
                img56.enabled = false;
                img12.enabled = false;
                img23.enabled = false;
            }
            if (ActiveObject == 1)
            {
                img1.enabled = true;
                img12.enabled = true;
                img1.transform.position = new Vector2(x1, y1);
                img12.transform.position = new Vector2(x12, y12);
                img0.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
                img45.enabled = false;
                img23.enabled = false;
                img56.enabled = false;
                img01.enabled = false;
                img34.enabled = false;
            }
            if (ActiveObject == 2)
            {
                img2.enabled = true;
                img23.enabled = true;
                img2.transform.position = new Vector2(x2, y2);
                img23.transform.position = new Vector2(x23, y23);
                img1.enabled = false;
                img0.enabled = false;
                img3.enabled = false;
                img12.enabled = false;
                img4.enabled = false;
                img56.enabled = false;
                img5.enabled = false;
                img45.enabled = false;
                img01.enabled = false;
                img34.enabled = false;
            }
            if (ActiveObject == 3)
            {
                img3.enabled = true;
                img34.enabled = true;
                img3.transform.position = new Vector2(x3, y3);
                img34.transform.position = new Vector2(x34, y34);
                img1.enabled = false;
                img2.enabled = false;
                img12.enabled = false;
                img0.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
                img23.enabled = false;
                img56.enabled = false;
                img01.enabled = false;
                img45.enabled = false;
            }
            if (ActiveObject == 4)
            {
                img4.enabled = true;
                img45.enabled = true;
                img4.transform.position = new Vector2(x4, y4);
                img45.transform.position = new Vector2(x45, y45);
                img1.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img0.enabled = false;
                img5.enabled = false;
                img34.enabled = false;
                img01.enabled = false;
                img23.enabled = false;
                img12.enabled = false;
                img56.enabled = false;
            }
            if (ActiveObject == 5)
            {
                img5.enabled = true;
                img56.enabled = true;
                img5.transform.position = new Vector2(x5, y5);
                img56.transform.position = new Vector2(x56, y56);
                img1.enabled = false;
                img23.enabled = false;
                img2.enabled = false;
                img3.enabled = false;
                img01.enabled = false;
                img4.enabled = false;
                img34.enabled = false;
                img0.enabled = false;
                img12.enabled = false;
                img45.enabled = false;
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
                img01.enabled = true;
                img012.enabled = true;
                img0123.enabled = true;
                img0.transform.position = new Vector2(x0, y0);
                img01.transform.position = new Vector2(x01, y01);
                img012.transform.position = new Vector2(x012, y012);
                img0123.transform.position = new Vector2(x0123, y0123);
                img1.enabled = false;
                img12.enabled = false;
                img2.enabled = false;
                img3456.enabled = false;
                img23.enabled = false;
                img234.enabled = false;
                img3.enabled = false;
                img34.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
                img45.enabled = false;
                img4567.enabled = false;
                img567.enabled = false;  
                img456.enabled = false;
                img345.enabled = false;
                img5678.enabled = false;
                img56.enabled = false;
                img123.enabled = false;
                img1234.enabled = false;
                img2345.enabled = false;
                img45678.enabled = false;
                img56789.enabled = false;
                img34567.enabled = false;
                img23456.enabled = false;
            }
            if (ActiveObject == 1)
            {
                img1.enabled = true;
                img12.enabled = true;
                img123.enabled = true;
                img1234.enabled = true;
                img1.transform.position = new Vector2(x1, y1);
                img12.transform.position = new Vector2(x12, y12);
                img123.transform.position = new Vector2(x123, y123);
                img1234.transform.position = new Vector2(x1234, y1234);
                img0.enabled = false;
                img01.enabled = false;
                img2.enabled = false;
                img5678.enabled = false;
                img23.enabled = false;
                img3.enabled = false;
                img4567.enabled = false;
                img45.enabled = false;
                img4.enabled = false;
                img234.enabled = false;
                img3456.enabled = false;
                img345.enabled = false;
                img34.enabled = false;
                img5.enabled = false;
                img56.enabled = false;
                img456.enabled = false;
                img012.enabled = false;
                img567.enabled = false;
                img0123.enabled = false;
                img2345.enabled = false;
                img45678.enabled = false;
                img56789.enabled = false;
                img34567.enabled = false;
                img23456.enabled = false;
            }
            if (ActiveObject == 2)
            {
                img2.enabled = true;
                img23.enabled = true;
                img234.enabled = true;
                img2345.enabled = true;
                img23456.enabled = true;
                img2.transform.position = new Vector2(x2, y2);
                img23.transform.position = new Vector2(x23, y23);
                img234.transform.position = new Vector2(x234, y234);
                img2345.transform.position = new Vector2(x2345, y2345);
                img23456.transform.position = new Vector2(x23456, y23456);
                img1.enabled = false;
                img12.enabled = false;
                img0.enabled = false;
                img45.enabled = false;
                img01.enabled = false;
                img34.enabled = false;
                img3.enabled = false;
                img123.enabled = false;
                img4.enabled = false;
                img5.enabled = false;
                img5678.enabled = false;
                img56.enabled = false;
                img012.enabled = false;
                img567.enabled = false;
                img3456.enabled = false;
                img4567.enabled = false;
                img456.enabled = false;
                img345.enabled = false;
                img0123.enabled = false;
                img1234.enabled = false;
                img45678.enabled = false;
                img56789.enabled = false;
                img34567.enabled = false;
            }
            if (ActiveObject == 3)
            {
                img3.enabled = true;
                img34.enabled = true;
                img345.enabled = true;
                img3456.enabled = true;
                img34567.enabled = true;
                img3.transform.position = new Vector2(x3, y3);
                img34.transform.position = new Vector2(x34, y34);
                img345.transform.position = new Vector2(x345, y345);
                img3456.transform.position = new Vector2(x3456, y3456);
                img34567.transform.position = new Vector2(x34567, y34567);
                img1.enabled = false;
                img12.enabled = false;
                img2.enabled = false;
                img0.enabled = false;
                img01.enabled = false;
                img45.enabled = false;
                img456.enabled = false;
                img4.enabled = false;
                img5.enabled = false; 
                img234.enabled = false;
                img23.enabled = false;
                img123.enabled = false;
                img567.enabled = false;
                img56.enabled = false;
                img012.enabled = false;
                img5678.enabled = false;
                img4567.enabled = false;
                img0123.enabled = false;
                img1234.enabled = false;
                img2345.enabled = false;
                img45678.enabled = false;
                img56789.enabled = false;
                img23456.enabled = false;
            }
            if (ActiveObject == 4)
            {
                img4.enabled = true;
                img45.enabled = true;
                img456.enabled = true;
                img4567.enabled = true;
                img45678.enabled = true;
                img456.transform.position = new Vector2(x456, y456);
                img45.transform.position = new Vector2(x45, y45);
                img4.transform.position = new Vector2(x4, y4);
                img4567.transform.position = new Vector2(x4567, y4567);
                img45678.transform.position = new Vector2(x45678, y45678);
                img1.enabled = false;
                img12.enabled = false;
                img2.enabled = false;
                img123.enabled = false;
                img234.enabled = false;
                img3456.enabled = false;
                img3.enabled = false;
                img34.enabled = false;
                img0.enabled = false;
                img01.enabled = false;
                img5.enabled = false;
                img23.enabled = false;
                img345.enabled = false;
                img56.enabled = false;
                img012.enabled = false;
                img567.enabled = false;
                img5678.enabled = false;
                img0123.enabled = false;
                img1234.enabled = false;
                img2345.enabled = false;
                img56789.enabled = false;
                img34567.enabled = false;
                img23456.enabled = false;
            }
            if (ActiveObject == 5)
            {
                img5.enabled = true;
                img56.enabled = true;
                img567.enabled = true;
                img5678.enabled = true;
                img56789.enabled = true;
                img5.transform.position = new Vector2(x5, y5);
                img56.transform.position = new Vector2(x56, y56);
                img567.transform.position = new Vector2(x567, y567);
                img5678.transform.position = new Vector2(x5678, y5678);
                img56789.transform.position = new Vector2(x56789, y56789);
                img1.enabled = false;
                img12.enabled = false;
                img2.enabled = false;
                img23.enabled = false;
                img3.enabled = false;
                img34.enabled = false;
                img4.enabled = false;
                img45.enabled = false;
                img3456.enabled = false;
                img234.enabled = false;
                img123.enabled = false;
                img0.enabled = false;
                img01.enabled = false;
                img4567.enabled = false;
                img456.enabled = false;
                img345.enabled = false;
                img012.enabled = false;
                img0123.enabled = false;
                img1234.enabled = false;
                img2345.enabled = false;
                img45678.enabled = false;
                img34567.enabled = false;
                img23456.enabled = false;

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
