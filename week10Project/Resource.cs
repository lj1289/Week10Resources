using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week10Project
{
    class Resource {// Base Class
        //Fields & Properties

    private string title;
    private int resourceISBN;
    private int pageNumbers;
    //----------------------------------------------
        public string Title
    {
        get { return this.title; }
        set { this.title = value; }
    }
        public int ResourceISBN

    {
        get { return this.resourceISBN; }
        set { this.resourceISBN = value;  }
    }

        public int PageNumbers
    {
        get { return this.pageNumbers; }
        set { this.pageNumbers = value;  }
    }
    {
        //Title(title of resource)
        //ISBN(ISBN number of resource)
        //Length(length of resource as # of pages)
        //Status (available or checked out)

      
    }
}
