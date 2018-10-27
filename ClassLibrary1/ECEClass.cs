using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
 
 
namespace Dtec
{
    public class ECEClass
    {
        public static XDocument xmlDoc = null;

        private  XDocument getDefaultECEXml()
        {
            XDocument xDoc = new XDocument(
            new XDeclaration("1.0", "UTF-8", "yes"),
            new XElement("letter",
                new XElement("Protocol", null, new XAttribute("Name", "ECE"), new XAttribute("Version", "1.01"),  new XAttribute("Any", "")),
                new XElement("Software", "RMAX", new XAttribute("Version", "2.0"), new XAttribute("SoftwareDeveloper", "شرکت مهندسی داده تامین خاورمیانه"), new XAttribute("GUID", "19750830-4637-41b0-9d36-24ea3c550525"),  new XAttribute("Any", "")),
                new XElement("Sender", null, new XAttribute("Name", ""), new XAttribute("Organization", ""), new XAttribute("Position", ""), new XAttribute("Code", ""), new XAttribute("Department", ""),  new XAttribute("Any", "")),
                new XElement("Receiver", null, new XAttribute("Name", ""), new XAttribute("Organization", ""), new XAttribute("Position", ""), new XAttribute("Code", ""), new XAttribute("Department", ""), new XAttribute("ReceiveType", ""),  new XAttribute("Any", "")),
                new XElement("OtherReceivers",null
                    ),
                new XElement("LetterNo","",  new XAttribute("Any", "")),
                new XElement("LetterDateTime","",new XAttribute("ShowAs",""),  new XAttribute("Any", "")),
                new XElement("RelatedLetters",null
                    ),
                new XElement("Subject","",  new XAttribute("Any", "")),
                new XElement("Priority","",new XAttribute("Code","") ,new XAttribute("Name",""), new XAttribute("Any", "")),
                new XElement("Classification", "", new XAttribute("Code", ""), new XAttribute("Name", ""), new XAttribute("Any", "")),
                new XElement("Keywords", "", new XAttribute("Keyword", ""),  new XAttribute("Any", "")),
                new XElement("Origins",null
                    ),
                new XElement("Attachments",null
                   
                   )

                ,  new XAttribute("Any", "")));

            //StringWriter sw = new StringWriter();
            //XmlWriter xWrite = XmlWriter.Create(sw);
            //xDoc.Save(xWrite);
            //xWrite.Close();

            //xDoc.Save("d:\\Something.xml");


            return xDoc;
        }
        
        public void loadECEXml(string fileFullPath)
        {
            try
            {
                TextReader reader = new StreamReader(fileFullPath);
                xmlDoc = XDocument.Load(reader);
                
            }
            catch (Exception ex)  { xmlDoc = null; }
            
        }

        public static string RemoveAllXmlNamespace(string xmlData)
        {
            string xmlnsPattern = "\\s+xmlns\\s*(:\\w)?\\s*=\\s*\\\"(?<url>[^\\\"]*)\\\"";
            MatchCollection matchCol = Regex.Matches(xmlData, xmlnsPattern);

            foreach (Match m in matchCol)
            {
                xmlData = xmlData.Replace(m.ToString(), "");
            }
            return xmlData;
        }
        
        public void initializeDefaultECEXml()
        {
           try
            {
               xmlDoc = getDefaultECEXml();
               
            }
           catch (Exception ex) { xmlDoc = null; }
        }

        public void initializeDefaultECEXml(string eceFilePath)
        {
            try
            {
                StreamReader sr = new StreamReader(eceFilePath);
                string xmlContent=sr.ReadToEnd();
                xmlDoc = XDocument.Parse(xmlContent);                
                
            }
            catch (Exception ex) { xmlDoc = null; }
        }

        public string exportEceXml()
        {
            StringWriter sw = new StringWriter();
            XmlWriter xWrite = XmlWriter.Create(sw);
            xmlDoc.Save(xWrite);
            xWrite.Close();

            return sw.ToString();
        }

        public bool exportEceXml(string fullPathToSaveXmlFile)
        {
            try
            {
                StringWriter sw = new StringWriter();
                XmlWriter xWrite = XmlWriter.Create(sw);
                xmlDoc.Save(xWrite);
                xWrite.Close();

                xmlDoc.Save(fullPathToSaveXmlFile);
            }
            catch (Exception ex)
            { return false; }

            return true;
        }

        public class Sender
        {
            System.Xml.Linq.XElement q;
            
            public Sender()
            {
                q = (from s in xmlDoc.Descendants()
                     where s.Name.LocalName =="Sender"
                        select s).FirstOrDefault();
            }

            public string Organization
            {
                set { q.Attribute("Organization").Value = value; }
                get { if (q == null)return ""; return q.Attribute("Organization").Value  ?? ""; }
            }

            public string Department
            {
                set { q.Attribute("Department").Value = value; }
                get { if (q == null)return ""; return q.Attribute("Department").Value  ?? ""; }
            }

            public string Position
            {
                set { q.Attribute("Position").Value = value; }
                get { if (q == null)return ""; return q.Attribute("Position").Value  ?? ""; }
            }

            public string Name
            {
                set { q.Attribute("Name").Value = value; }
                get { if (q == null)return "";  return q.Attribute("Name").Value ?? ""; }
            }

            public string Code
            {
                set { q.Attribute("Code").Value = value; }
                get { if (q == null)return ""; return q.Attribute("Code").Value  ?? ""; }
            }

            public string Any
            {
                set { q.Attribute("Any").Value = value; }
                get { if (q == null)return "";  return q.Attribute("Any").Value ?? ""; }
            }

        }
         
        public class Receiver
        {
            System.Xml.Linq.XElement q;

            public Receiver()
            {
                q = (from s in xmlDoc.Descendants()
                     where s.Name.LocalName =="Receiver"
                        select s).FirstOrDefault();
            }

            public string Organization
            {
                set { q.Attribute("Organization").Value = value; }
                get { if (q == null)return "";  return q.Attribute("Organization").Value ?? ""; }
            }

            public string Department
            {
                set { q.Attribute("Department").Value = value; }
                get { if (q == null)return "";  return q.Attribute("Department").Value!=null?"":""; }
            }

            public string Position
            {
                set { q.Attribute("Position").Value = value; }
                get { if (q == null)return "";  return q.Attribute("Position").Value ?? ""; }
            }

            public string Name
            {
                set { q.Attribute("Name").Value = value; }
                get { if (q == null)return "";  return q.Attribute("Name").Value ?? ""; }
            }

            public string Code
            {
                set { q.Attribute("Code").Value = value; }
                get { if (q == null)return "";  return q.Attribute("Code").Value ?? ""; }
            }

            public string ReceiveType
            {
                set { q.Attribute("ReceiveType").Value = value; }
                get { if (q == null)return "";  return q.Attribute("ReceiveType").Value ?? ""; }
            }
            
            public string Any
            {
                set { q.Attribute("Any").Value = value; }
                get { if (q == null)return "";  return q.Attribute("Any").Value ?? ""; }
            }
        }

        public class OtherReceiver
        {
            public string Organization
            {
                set;
                get;
            }

            public string Department
            {
                set;
                get;
            }

            public string Position
            {
                set;
                get;
            }

            public string Name
            {
                set;
                get;
            }

            public string Code
            {
                set;
                get;
            }

            public string ReceiveType
            {
                set;
                get;
            }

            public string Any
            {
                set;
                get;
            }
        }

        public class LetterNo
        {
            System.Xml.Linq.XElement q;

            public LetterNo()
            {
                q = (from s in xmlDoc.Descendants()
                     where s.Name.LocalName =="LetterNo"
                        select s).FirstOrDefault();
            }

            public string _LetterNo
            {
                set { q.Value = value; }
                get { if (q == null)return "";  return q.Value ?? ""; }
            }

            public string Any
            {
                set { q.Attribute("Any").Value = value; }
                get { if (q == null)return "";  return q.Attribute("Any").Value ?? ""; }
            }

        }

        public class LetterDateTime
        {
            System.Xml.Linq.XElement q;
            public LetterDateTime()
            {
                q = (from s in xmlDoc.Descendants()
                     where s.Name.LocalName =="LetterDateTime"
                        select s).FirstOrDefault();
            }

            public string _LetterDateTime
            {
                set { q.Value = value; }
                get { if (q == null)return "";  return q.Value ?? ""; }
            }

            public string ShowAs
            {
                set { q.Attribute("ShowAs").Value = value; }
                get { if (q == null)return "";  return q.Attribute("ShowAs").Value ?? ""; }
            }

            public string Any
            {
                set { q.Attribute("Any").Value = value; }
                get { if (q == null)return "";  return q.Attribute("Any").Value ?? ""; }
            }

        }

        public class Subject
        {
            System.Xml.Linq.XElement q;
            public Subject()
            {
                q = (from s in xmlDoc.Descendants()
                     where s.Name.LocalName == "Subject"
                     select s).FirstOrDefault();
            }

            public string _Subject
            {
                set { q.Value = value; }
                get { if (q == null)return "";  return q.Value ?? ""; }
            }

            public string Any
            {
                set { q.Attribute("Any").Value = value; }
                get { if (q == null)return "";  return q.Attribute("Any").Value ?? ""; }
            }

        }

        public class Priority
        {
            System.Xml.Linq.XElement q;
            public Priority()
            {
                q = (from s in xmlDoc.Descendants()
                     where s.Name.LocalName == "Priority"
                        select s).FirstOrDefault();
            }

           
            public string Code
            {
                set { q.Attribute("Code").Value = value; }
                get { if (q == null)return "";  return q.Attribute("Code").Value ?? ""; }
            }

            public string Name
            {
                set { q.Attribute("Name").Value = value; }
                get { if (q == null)return ""; return q.Attribute("Name").Value ?? ""; }
            }

            public string Any
            {
                set { q.Attribute("Any").Value = value; }
                get { if (q == null)return "";  return q.Attribute("Any").Value ?? ""; }
            }

        }

        public class Classification
        {
            System.Xml.Linq.XElement q;
            public Classification()
            {
                q = (from s in xmlDoc.Descendants()
                     where s.Name.LocalName == "Classification"
                        select s).FirstOrDefault();
            }

            public string Code
            {
                set { q.Attribute("Code").Value = value; }
                get { if (q == null)return ""; return q.Attribute("Code").Value  ?? ""; }
            }

            public string Name
            {
                set { q.Attribute("Name").Value = value; }
                get { if (q == null)return ""; return q.Attribute("Name").Value ?? ""; }
            }

            public string Any
            {
                set { q.Attribute("Code").Value = value; }
                get { if (q == null)return ""; return q.Attribute("Code").Value  ?? ""; }
            }

        }

        public class Keywords
        {
            System.Xml.Linq.XElement q;
            public Keywords()
            {
                q = (from s in xmlDoc.Descendants()
                     where s.Name.LocalName == "Keywords"
                        select s).FirstOrDefault();
            }

            public string Keyword
            {
                set { q.Attribute("Keyword").Value = value; }
                get { if (q == null)return "";  if (q == null)return "";  return q.Attribute("Keyword").Value  ?? ""; }
            }

            public string Any
            {
                set { q.Attribute("Any").Value = value; }
                get { if (q == null)return ""; return q.Attribute("Any").Value  ?? ""; }
            }

        }

        public class Origin
        {
            public string encodedBase64String
            {
                set;
                get;
            }

            public string ContentType
            {
                set;
                get;
            }

            public string Extension
            {
                set;
                get;
            }

            public string Description
            {
                set;
                get;
            }

            public string Any
            {
                set;
                get;
            }

        }

        public class Origins
        {
            public void addOrigin(Origin origin)
            {
                System.Xml.Linq.XElement q;
                q = (from s in xmlDoc.Descendants()
                     where s.Name.LocalName =="Origins" 
                     select s).FirstOrDefault();

                XElement xelement = new XElement("Origin", origin.encodedBase64String);
                XAttribute xAttDesc = new XAttribute("Description", origin.Description);
                XAttribute xAttExtension = new XAttribute("Extension", origin.Extension);
                XAttribute xAttContentType = new XAttribute("ContentType", origin.ContentType);
                if (origin.Any != null)
                {
                    XAttribute xAttAny = new XAttribute("Any", origin.Any);
                    xelement.Add(xAttAny);
                }
                xelement.Add(xAttDesc);
                xelement.Add(xAttExtension);
                xelement.Add(xAttContentType);
                
                q.Add(xelement);
                
            }

            public List<Origin> getOrigins()
            {
                List<Origin> lstOrigin=new List<Origin>();
                var q = (from s in xmlDoc.Descendants()
                         where s.Name.LocalName == "Origin"
                     select s).ToList();
                
                foreach(var item in q)
                {
                    Origin or = new Origin();
                    or.encodedBase64String = (string)item.Value;
                    or.Any = (string)item.Attribute("Any");
                    or.ContentType = (string)item.Attribute("ContentType");
                    or.Description = (string)item.Attribute("Description");
                    or.Extension = (string)item.Attribute("Extension");
                    lstOrigin.Add(or);
                }

                return lstOrigin;
            }
        }

        public class OtherReceivers
        {
            public void addOtherReceiver(OtherReceiver receiver)
            {
                System.Xml.Linq.XElement q;
                q = (from s in xmlDoc.Descendants()
                     where s.Name.LocalName == "OtherReceivers"
                     select s).FirstOrDefault();

                XElement xelement = new XElement("OtherReceiver",null);

                XAttribute xAttAny = new XAttribute("Any", receiver.Any==null?"": receiver.Any);
                XAttribute xAttCode = new XAttribute("Code", receiver.Code);
                XAttribute xAttDepartment = new XAttribute("Department", receiver.Department == null ? "" : receiver.Department);
                XAttribute xAttName = new XAttribute("Name", receiver.Name == null ? "" : receiver.Name);
                XAttribute xAttOrganization = new XAttribute("Organization", receiver.Organization == null ? "" : receiver.Organization);
                XAttribute xAttPosition = new XAttribute("Position", receiver.Position == null ? "" : receiver.Position);
                XAttribute xAttReceiveType = new XAttribute("ReceiveType", receiver.ReceiveType);

                xelement.Add(xAttAny);
                xelement.Add(xAttCode);
                xelement.Add(xAttDepartment);
                xelement.Add(xAttName);
                xelement.Add(xAttOrganization);
                xelement.Add(xAttPosition);
                xelement.Add(xAttReceiveType);
                
                q.Add(xelement);

            }

            public List<OtherReceiver> getOtherRecivers()
            {
                List<OtherReceiver> lstReceiver = new List<OtherReceiver>();
                var q = (from s in xmlDoc.Descendants()
                         where s.Name.LocalName == "OtherReceiver"
                         select s).ToList();

                foreach (var item in q)
                {
                    OtherReceiver rc = new OtherReceiver();
                    rc.Any = (string)item.Attribute("Any");
                    rc.Code = (string)item.Attribute("Code");
                    rc.Department = (string)item.Attribute("Department");
                    rc.Name = (string)item.Attribute("Name");
                    rc.Organization = (string)item.Attribute("Organization");
                    rc.Position = (string)item.Attribute("Position");
                    rc.ReceiveType = (string)item.Attribute("ReceiveType");

                    lstReceiver.Add(rc);
                }

                return lstReceiver;
            }


        }

        public class Attachment
        {
            public string encodedBase64String
            {
                set;
                get;
            }

            public string ContentType
            {
                set;
                get;
            }

            public string Extension
            {
                set;
                get;
            }

            public string Description
            {
                set;
                get;
            }

            public string Any
            {
                set;
                get;
            }
        }

        public class Attachments
        {
            public void addAttachment(Attachment attachment)
            {
                System.Xml.Linq.XElement q;
                q = (from s in xmlDoc.Descendants()
                     where s.Name.LocalName == "Attachments"
                     select s).FirstOrDefault();

                XElement xelement = new XElement("Attachment", attachment.encodedBase64String);
                XAttribute xAttDesc = new XAttribute("Description", attachment.Description);
                XAttribute xAttExtension = new XAttribute("Extension", attachment.Extension);
                XAttribute xAttContentType = new XAttribute("ContentType", attachment.ContentType);
                if (attachment.Any != null)
                {
                    XAttribute xAttAny = new XAttribute("Any", attachment.Any);
                    xelement.Add(xAttAny);
                }
                xelement.Add(xAttDesc);
                xelement.Add(xAttExtension);
                xelement.Add(xAttContentType);
                
                q.Add(xelement);
            }

            public List<Attachment> getAttachment()
            {
                List<Attachment> lstAttachment = new List<Attachment>();
                var q = (from s in xmlDoc.Descendants()
                         where s.Name.LocalName == "Attachment"
                         select s).ToList();

                foreach (var item in q)
                {
                    Attachment at = new Attachment();
                    at.encodedBase64String = (string)item.Value;
                    at.Any = (string)item.Attribute("Any");
                    at.ContentType = (string)item.Attribute("ContentType");
                    at.Description = (string)item.Attribute("Description");
                    at.Extension = (string)item.Attribute("Extension");
                    
                    lstAttachment.Add(at);
                }

                return lstAttachment;
            }
        }

        public class RelationType
        {
            public string Name
            {
                set;
                get;

            }

            public string code
            {
                set;
                get;

            }

            public string Any
            {
                set;
                get;

            }

        }

        public class RelatedLetter
        {
            public RelationType RelationType
            {
                set;
                get;
            }

            public LetterNo RelatedLetterNO
            {
                set;
                get;
            }

            public LetterDateTime RelatedLetterDateTime
            {
                set;
                get;
            }

            public Sender RelatedLetterSender
            {
                set;
                get;
            }
        }

        public class RelatedLetters
        {
            public void addRelatedLetter(RelatedLetter relatedLetter)
            {
                System.Xml.Linq.XElement q;
                q = (from s in xmlDoc.Descendants()
                     where s.Name.LocalName == "RelatedLetters"
                     select s).FirstOrDefault();

                XElement xelement = new XElement("RelatedLetter", null);
                XElement xRelatedLetterDateTime = new XElement("RelatedLetterDateTime",relatedLetter.RelatedLetterDateTime._LetterDateTime,new XAttribute("ShowAs",relatedLetter.RelatedLetterDateTime.ShowAs),new XAttribute("Any",relatedLetter.RelatedLetterDateTime.Any));
                XElement xRelatedLetterNO = new XElement("RelatedLetterNO", relatedLetter.RelatedLetterNO._LetterNo, new XAttribute("Any",relatedLetter.RelatedLetterNO.Any));
                XElement xRelatedLetterSender = new XElement("RelatedLetterSender", null, new XAttribute("Any", relatedLetter.RelatedLetterSender.Any), new XAttribute("Code", relatedLetter.RelatedLetterSender.Code), new XAttribute("Department", relatedLetter.RelatedLetterSender.Department), new XAttribute("Name", relatedLetter.RelatedLetterSender.Name), new XAttribute("Organization", relatedLetter.RelatedLetterSender.Organization), new XAttribute("Position", relatedLetter.RelatedLetterSender.Position));
                XElement xRelationType = new XElement("RelationType", null, new XAttribute("Any", relatedLetter.RelationType.Any), new XAttribute("code", relatedLetter.RelationType.code), new XAttribute("Name", relatedLetter.RelationType.Name));

                xelement.Add(xRelatedLetterDateTime);
                xelement.Add(xRelatedLetterNO);
                xelement.Add(xRelatedLetterNO);
                xelement.Add(xRelatedLetterSender);
                xelement.Add(xRelationType);

                q.Add(xelement);
            }

            public List<RelatedLetter> getRelatedLetters()
            {
                List<RelatedLetter> lstRelatedLetter = new List<RelatedLetter>();
                var q = (from s in xmlDoc.Descendants()
                         where s.Name.LocalName =="RelatedLetter"
                         select s).ToList();

                foreach (var item in q)
                {
                    RelatedLetter rl = new RelatedLetter();

                    XElement xelmentRelatedLetterDateTime= item.Element("RelatedLetterDateTime");
                    LetterDateTime letterDateTime=new LetterDateTime();
                    letterDateTime._LetterDateTime=xelmentRelatedLetterDateTime.Value;
                    letterDateTime.Any=(string)xelmentRelatedLetterDateTime.Attribute("Any");
                    letterDateTime.ShowAs=(string)xelmentRelatedLetterDateTime.Attribute("ShowAs");
                    rl.RelatedLetterDateTime=letterDateTime;

                    XElement xelmentRelatedLetterNO= item.Element("RelatedLetterNO");
                    LetterNo letterno=new LetterNo();
                    letterno._LetterNo=xelmentRelatedLetterNO.Value;
                    letterno.Any=(string)xelmentRelatedLetterNO.Attribute("Any");
                    rl.RelatedLetterNO=letterno;

                    XElement xelmentRelatedLetterSender= item.Element("RelatedLetterSender");
                    Sender sender =new Sender();
                    sender.Any=(string)xelmentRelatedLetterSender.Attribute("Any");
                    sender.Code=(string)xelmentRelatedLetterSender.Attribute("Code");
                    sender.Department=(string)xelmentRelatedLetterSender.Attribute("Department");
                    sender.Name=(string)xelmentRelatedLetterSender.Attribute("Name");
                    sender.Organization=(string)xelmentRelatedLetterSender.Attribute("Organization");
                    sender.Position=(string)xelmentRelatedLetterSender.Attribute("Position");
                    rl.RelatedLetterSender=sender;

                    XElement xelmentRelationType= item.Element("RelationType");
                    RelationType relationType=new RelationType();
                    relationType.Any=(string)xelmentRelationType.Attribute("Any");
                    relationType.code=(string)xelmentRelationType.Attribute("code");
                    relationType.Name=(string)xelmentRelationType.Attribute("Name");
                    rl.RelationType=relationType;
                    

                    lstRelatedLetter.Add(rl);
                }

                return lstRelatedLetter;
            }
        }

        public bool createBinaryFileFromECEText(string fileFullPath,string EncodedBase64Text)
        {
            try
            {
                FileStream fs = new FileStream(fileFullPath , FileMode.CreateNew);

                BinaryWriter w = new BinaryWriter(fs);
                byte[] decodedBytes = Convert.FromBase64String(EncodedBase64Text);
                for (int i = 0; i < decodedBytes.Length; i++)
                {
                    w.Write(decodedBytes[i]);
                }
                w.Flush();
                w.Close();
            }
            catch (Exception ex)
            { return false; }

            return true;
        }

        public string createECEBase64EncodedText(string fileFullPath)
        {
            string encodedBase64Text = null;
            try
            {
                FileStream fs = new FileStream(fileFullPath, FileMode.Open, FileAccess.Read);
                BinaryReader r = new BinaryReader(fs, Encoding.UTF8);
                int lenFile = int.Parse(fs.Length.ToString());
                byte[] readBytes = r.ReadBytes(lenFile);

                encodedBase64Text = Convert.ToBase64String(readBytes);

                r.Close();
                fs.Close();
            }
            catch (Exception ex) { return null;}

            return encodedBase64Text;
        }
      
        
    }
}
