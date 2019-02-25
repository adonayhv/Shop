using Shop.IUForms.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.IUForms.InfrasStructure
{
  public  class InstanceLocator
    {
        public MainViewModel Main { get; set; }
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }

    }
}

