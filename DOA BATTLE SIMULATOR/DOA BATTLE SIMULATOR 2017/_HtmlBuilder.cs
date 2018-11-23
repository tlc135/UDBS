using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;

public class _HtmlBuilder
{

    private string _css;
    private string _header;
    private string _header2;
    private string _body;
    private string _body2;
    private string _foot;
    private string _subX;
    private string _subY;

    public _HtmlBuilder(string css, string header, string header2, string body, string body2, string subX, string subY, string foot)
    {
        _css = css;
        _header = header;
        _header2 = header2;
        _foot = foot;
        _body = body;
        _body2 = body2;
        _subX = subX;
        _subY = subY;

    }


    public void output()
    {
        string footX = null;
        string footY = null;

        int iX = 1;
        int iY = 1;
        string name = null;
        string amount = null;
        string element = null;
        string body_sanctX = null;
        string body_sanctX_a = null;
        string body_sanctY = null;
        string body_sanctY_a = null;

        using (StreamWriter sw = new StreamWriter("C:\\DRV\\report.html"))
        {
          
        }
    }



}