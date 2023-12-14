namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactEventListenerSchema

	/// <exclude/>
	public class ContactEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactEventListenerSchema(ContactEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7bbed3c8-78ef-49dc-a0ac-f1c79bd9a80b");
			Name = "ContactEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3e2142cb-b5f1-4ce8-8571-f789e137e2ae");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,193,110,219,48,12,61,167,64,255,129,240,14,117,128,194,190,167,113,128,46,235,186,2,235,58,180,105,47,195,14,140,69,219,26,108,41,144,228,0,70,177,127,31,45,217,217,18,56,152,111,164,222,211,227,123,162,21,54,100,119,152,19,108,200,24,180,186,112,201,90,171,66,150,173,65,39,181,186,188,120,191,188,152,181,86,170,18,94,58,235,168,185,57,212,103,40,201,83,163,100,94,161,82,84,39,143,100,45,150,140,158,166,25,74,238,148,147,78,146,253,47,32,185,219,147,114,61,142,145,31,12,149,172,5,235,26,173,93,0,15,224,48,119,30,241,85,242,152,138,140,199,165,105,10,75,219,54,13,154,110,53,212,35,0,10,109,224,106,160,94,1,245,58,29,144,87,73,70,110,122,66,94,90,34,172,173,134,220,80,145,69,31,209,146,31,176,59,210,142,32,237,9,63,38,142,226,151,188,162,6,191,113,242,144,65,52,200,71,243,159,140,223,181,219,90,230,144,247,166,38,61,193,2,206,40,50,251,221,59,62,68,243,72,174,210,130,195,249,238,111,13,135,167,121,248,198,23,84,162,38,59,38,240,137,106,114,36,66,18,201,129,149,158,210,150,59,52,216,128,98,39,89,100,73,9,246,189,242,67,65,168,146,101,234,33,211,12,138,86,155,138,124,160,67,152,155,197,217,167,247,147,221,22,142,140,23,184,53,165,237,51,6,169,172,67,197,251,155,247,105,73,213,239,143,171,104,20,244,22,64,160,195,163,89,134,156,245,158,229,164,32,216,107,41,224,73,13,198,99,189,253,69,249,104,226,26,166,196,129,230,208,255,25,179,217,150,223,35,249,203,29,73,52,191,241,199,129,28,198,227,59,51,136,67,103,30,128,1,180,71,3,60,65,54,194,146,123,114,155,110,71,98,173,235,182,81,111,88,183,180,188,111,165,88,197,209,131,136,134,171,255,249,207,134,93,121,16,253,19,22,146,163,127,166,134,237,133,134,235,62,27,221,172,145,23,47,150,226,250,160,242,106,201,48,83,177,89,94,152,112,235,239,97,137,120,186,176,71,190,14,221,227,166,239,245,223,31,131,204,245,123,69,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7bbed3c8-78ef-49dc-a0ac-f1c79bd9a80b"));
		}

		#endregion

	}

	#endregion

}

