using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DateLogique : MonoBehaviour
{
    public TMP_Text dateResult;
    public Color32 c;
    public void btnnum(char num)
    {
        
        //dateResult.color = c;
        if (dateResult.text.Length != 4)
        {
            while (dateResult.text.Length < 4)
            {
                dateResult.text += '.';
            }
        }

        if (dateResult.text.Contains('.'))
        {
            bool test = false;
            string date = "";
            for (int i = 0; i < dateResult.text.Length; i++)
            {

                if (dateResult.text[i] == '.' && !test)
                {
                    test = true;
                    date += num;
                }
                else
                {
                    date += dateResult.text[i];
                }
            }
            dateResult.text = date;

        }
        else
        {

        }

    }
    public void btn0()
    {
        btnnum('0');
    }
    public void btn1()
    {
        btnnum('1');
    }
    public void btn2()
    {
        btnnum('2');
    }
    public void btn3()
    {
        btnnum('3');
    }
    public void btn4()
    {
        btnnum('4');
    }
    public void btn5()
    {
        btnnum('5');
    }
    public void btn6()
    {
        btnnum('6');
    }
    public void btn7()
    {
        btnnum('7');
    }
    public void btn8()
    {
        btnnum('8');
    }
    public void btn9()
    {
        btnnum('9');
    }

    public void btnReturn()
    {
        bool test = false;
        int index = 4;
        string date = "";
        if (dateResult.text.Length != 4)
        {
            while (dateResult.text.Length < 4)
            {
                dateResult.text += '.';
            }
        }
        for (int i = 0; i < dateResult.text.Length; i++)
        {

            if (dateResult.text[i] == '.' && test == false)
            {
                index = i;
                test = true;
                
            }
        }
        //Console.WriteLine(index);
        if (index != 1)
        {
            for (int i = 0; i < 4; i++)
            {
                if (i == index - 1)
                {
                    date += '.';
                }
                else
                {
                    date += dateResult.text[i];
                }
            }
            dateResult.text = date;
        }
        
        
        
        
    }

    void Maj()
    {
        
    }

}
