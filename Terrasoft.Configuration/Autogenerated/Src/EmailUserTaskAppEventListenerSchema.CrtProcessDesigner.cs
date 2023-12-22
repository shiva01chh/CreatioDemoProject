namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailUserTaskAppEventListenerSchema

	/// <exclude/>
	public class EmailUserTaskAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailUserTaskAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailUserTaskAppEventListenerSchema(EmailUserTaskAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b705c5b2-4b1a-4681-ad77-4eae6a95afd7");
			Name = "EmailUserTaskAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("da7de29a-d2b3-4248-bf8e-b7a592dc81f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,144,193,106,194,64,16,134,207,9,228,29,6,188,212,139,15,96,79,69,114,16,44,21,180,244,188,110,198,184,152,204,134,153,137,20,74,223,189,211,77,149,128,84,196,189,44,51,251,255,255,55,59,228,90,148,206,121,132,45,50,59,137,123,157,45,34,227,108,205,209,163,136,21,180,15,117,207,78,67,164,34,255,42,242,34,207,122,9,84,143,28,31,184,51,97,219,70,122,78,239,19,198,218,228,176,104,156,200,28,202,214,133,230,93,144,183,78,142,47,93,87,158,144,116,21,68,145,144,147,161,235,119,77,240,224,127,245,183,229,48,135,229,117,68,102,115,101,23,236,43,234,33,86,6,94,167,216,68,56,35,78,49,84,240,70,22,177,81,199,250,116,206,178,127,42,126,42,248,225,158,66,74,252,254,199,91,82,245,136,115,99,27,181,1,31,38,255,249,239,166,79,144,170,97,39,86,13,189,113,171,200,173,55,62,63,5,197,6,237,14,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b705c5b2-4b1a-4681-ad77-4eae6a95afd7"));
		}

		#endregion

	}

	#endregion

}

