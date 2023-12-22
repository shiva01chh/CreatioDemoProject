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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,193,110,219,48,12,61,167,64,255,129,240,14,117,128,194,190,167,113,128,46,235,186,2,235,58,172,217,46,197,14,140,69,219,26,108,41,144,228,0,70,177,127,31,45,217,89,19,56,168,111,164,222,211,227,123,162,21,54,100,119,152,19,108,200,24,180,186,112,201,90,171,66,150,173,65,39,181,186,188,120,189,188,152,181,86,170,18,158,59,235,168,185,57,212,103,40,201,83,163,100,94,161,82,84,39,143,100,45,150,140,158,166,25,74,238,148,147,78,146,125,23,144,220,237,73,185,30,199,200,15,134,74,214,130,117,141,214,46,128,7,112,152,59,143,248,42,121,76,69,198,227,210,52,133,165,109,155,6,77,183,26,234,17,0,133,54,112,53,80,175,128,122,157,14,200,171,36,35,55,61,33,47,45,17,214,86,67,110,168,200,162,143,104,201,15,216,29,105,71,144,246,132,151,137,163,248,57,175,168,193,111,156,60,100,16,13,242,209,252,55,227,119,237,182,150,57,228,189,169,73,79,176,128,51,138,204,126,245,142,15,209,60,146,171,180,224,112,190,251,91,195,225,105,30,190,241,5,149,168,201,142,9,124,162,154,28,137,144,68,114,96,165,167,180,229,14,13,54,160,216,73,22,89,82,130,125,175,252,80,16,170,100,153,122,200,52,131,162,213,166,34,31,232,16,230,102,113,246,233,253,100,183,133,35,227,5,110,77,105,251,140,65,42,235,80,241,254,230,125,90,82,245,251,227,42,26,5,189,5,16,232,240,104,150,33,103,189,103,57,41,8,246,90,10,120,82,131,241,88,111,255,80,62,154,184,134,41,113,160,57,244,127,198,108,182,229,247,72,254,115,71,18,205,111,252,113,32,135,241,248,206,12,226,208,153,7,96,0,237,209,0,79,144,141,176,228,158,220,166,219,145,88,235,186,109,212,47,172,91,90,222,183,82,172,226,232,65,68,195,213,111,254,179,97,87,30,68,255,132,133,228,232,127,80,195,246,66,195,117,159,141,110,214,200,139,23,75,113,125,80,249,105,201,48,83,177,89,94,152,112,235,223,97,137,120,186,176,71,190,14,221,227,166,239,189,253,254,1,188,237,253,222,77,4,0,0 };
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

