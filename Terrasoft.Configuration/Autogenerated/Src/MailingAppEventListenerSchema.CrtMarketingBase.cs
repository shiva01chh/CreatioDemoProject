namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingAppEventListenerSchema

	/// <exclude/>
	public class MailingAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingAppEventListenerSchema(MailingAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1f77b591-a8a7-4600-8f2b-2803c4f5ce85");
			Name = "MailingAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d6cb3076-08d5-49e6-ac18-d8f418ab1e90");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,77,111,219,48,12,61,167,64,255,3,225,93,210,139,125,111,62,128,180,104,183,2,45,86,172,11,122,24,134,130,177,233,76,152,45,9,148,108,44,43,246,223,199,72,118,17,59,237,214,28,28,232,241,241,137,122,36,53,214,228,44,230,4,95,137,25,157,41,125,122,105,116,169,182,13,163,87,70,159,158,60,159,158,76,26,167,244,118,64,97,154,189,130,63,210,70,98,117,109,180,68,37,254,129,105,43,34,112,89,161,115,231,112,135,170,146,132,149,181,87,45,105,127,171,156,39,77,28,168,89,150,193,220,53,117,141,188,91,118,231,47,100,153,156,48,29,212,228,127,152,194,129,55,160,180,242,10,43,245,155,64,42,255,137,91,74,251,252,236,64,192,54,155,74,229,144,239,175,126,235,102,56,135,49,116,129,142,36,251,57,20,245,242,128,107,69,85,33,47,184,103,213,162,167,24,180,241,0,107,71,44,166,105,202,247,142,193,83,51,56,207,58,37,210,69,20,27,42,223,197,135,189,79,250,35,249,33,50,237,203,23,200,211,47,15,121,252,63,131,125,219,38,19,85,194,116,84,15,44,22,160,155,170,234,41,147,22,25,208,90,97,244,132,94,37,21,117,241,48,12,194,183,100,21,56,29,41,249,14,232,96,0,205,162,220,209,117,3,241,244,97,39,62,215,235,177,69,146,248,39,124,153,124,195,175,153,24,8,239,115,50,116,62,6,199,99,21,128,11,165,101,148,186,225,113,18,39,130,156,169,92,36,97,80,175,49,247,134,119,73,182,4,37,181,186,244,69,40,27,43,205,45,50,214,160,101,141,22,73,231,90,178,188,209,206,163,150,165,50,229,161,248,168,87,162,159,206,179,32,16,244,186,129,53,173,172,147,42,8,90,163,10,248,172,37,235,193,35,251,255,181,122,223,198,35,235,143,7,166,207,138,158,119,123,241,9,117,81,17,187,181,151,163,87,228,210,43,141,155,138,86,146,211,210,61,155,86,10,226,158,53,29,94,115,246,143,230,68,116,8,6,236,240,247,23,16,176,161,104,133,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1f77b591-a8a7-4600-8f2b-2803c4f5ce85"));
		}

		#endregion

	}

	#endregion

}

