//
// Ostankov Alexander
// Higher School of Economics
// sashaostankov@gmail.com
// (c) 2015
//

using System;
using System.Collections.Generic;
using System.Xml;
using DataIO;

public static class IOManager
{
    static string file;

    public static string FileName { 
        get
        {
            return file;
        }
        set
        {
            if (value.EndsWith(FileExt))
                file = value;
            else
                file = string.Empty;                
        }
    }
    public const string FileExt = @".trains";

    public static bool ReadXMLFile(
        out List<TrainData> data,
        string fileName = null)
    {
        data = new List<TrainData>();
        string file;

        if (!string.IsNullOrEmpty(fileName))
            file = fileName;
        else if (!string.IsNullOrEmpty(FileName))
            file = FileName;
        else
            return false;

        if (!file.EndsWith(FileExt))
            return false;

        try
        {
            var xml = new XmlDocument();
            xml.Load(file);

            foreach (XmlNode it in xml.DocumentElement.ChildNodes)
            {
                var loco = new TrainData();

                loco.Id = it.Attributes.GetNamedItem("id").Value;

                foreach (XmlNode attributes in it.ChildNodes)
                {
                    switch (attributes.Name)
                    {
                        case "type": loco.Type = attributes.InnerText; break;
                        case "model": loco.Model = attributes.InnerText; break;
                        case "create": loco.Create = attributes.InnerText; break;
                        case "repair": loco.Repair = attributes.InnerText; break;
                    }
                }

                if (!loco.IsValidData())
                    throw new Exception("Invalid input data!");

                data.Add(loco);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return false;
        }

        return true;
    }

    public static bool WriteDataToXML
    (
        List<TrainData> data,
        bool append = false,
        string fileName = null
    )
    {
        string file;

        if (data == null)
            return false;

        if (!string.IsNullOrEmpty(fileName))
            file = fileName;
        else if (!string.IsNullOrEmpty(FileName))
            file = FileName;
        else
            return false;

        if (!file.EndsWith(FileExt))
            return false;

        try
        {
            var xml = new XmlDocument();

            if (append)
                xml.Load(file);
            else
                xml.LoadXml("<list></list>");

            foreach (var loco in data)
            {
                var xmlLoco = xml.CreateElement("lokomotiv");

                xml.DocumentElement.AppendChild(xmlLoco);

                var xmlType = xml.CreateElement("type");
                var xmlModel = xml.CreateElement("model");
                var xmlCreate = xml.CreateElement("create");
                var xmlRepair = xml.CreateElement("repair");

                xmlType.InnerText = loco.Type;
                xmlModel.InnerText = loco.Model;
                xmlCreate.InnerText = loco.Create;
                xmlRepair.InnerText = loco.Repair;

                xmlLoco.AppendChild(xmlType);
                xmlLoco.AppendChild(xmlModel);
                xmlLoco.AppendChild(xmlCreate);
                xmlLoco.AppendChild(xmlRepair);

                var id = xml.CreateAttribute("id");
                id.Value = loco.Id;

                xmlLoco.Attributes.Append(id);
            }

            xml.PreserveWhitespace = true;

            xml.Save(file);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return false;
        }

        return true;
    }

    static IOManager()
    {
        FileName = string.Empty;
    }
}