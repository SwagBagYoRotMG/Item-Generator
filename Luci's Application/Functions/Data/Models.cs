using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

[Serializable, XmlRoot("Item")]
public class ProjectItem
{
    public string Icon { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int RegDate { get; set; }
    public string Serial { get; set; }
    public string Desc { get; set; }
}