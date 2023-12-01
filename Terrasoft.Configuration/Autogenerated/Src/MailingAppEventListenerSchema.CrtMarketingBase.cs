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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,77,79,219,64,16,61,7,137,255,48,114,47,225,98,223,201,135,20,16,20,36,80,81,105,196,161,170,170,137,61,78,87,172,119,173,217,181,213,20,245,191,119,178,107,35,236,80,32,7,71,251,230,205,219,217,55,51,6,43,114,53,230,4,223,136,25,157,45,125,122,110,77,169,182,13,163,87,214,28,31,61,29,31,77,26,167,204,118,64,97,154,189,130,63,208,70,98,85,101,141,68,37,254,137,105,43,34,112,174,209,185,83,184,69,165,37,97,85,215,23,45,25,127,163,156,39,67,28,168,89,150,193,220,53,85,133,188,91,118,231,175,84,51,57,97,58,168,200,255,178,133,3,111,65,25,229,21,106,245,135,64,42,127,196,45,165,125,126,246,66,160,110,54,90,229,144,239,175,254,223,205,112,10,99,232,12,29,73,246,83,40,234,249,1,151,138,116,33,47,184,99,213,162,167,24,172,227,1,214,142,88,76,51,148,239,29,131,159,205,224,60,235,148,200,20,81,108,168,124,27,31,246,49,233,207,228,135,200,180,47,95,32,79,191,61,228,241,255,4,246,109,155,76,84,9,211,81,61,176,88,128,105,180,238,41,147,22,25,176,174,133,209,19,122,149,84,212,197,195,48,8,223,147,85,224,116,164,228,7,160,131,1,52,139,114,7,215,13,196,211,251,157,248,92,173,199,22,73,226,223,240,101,242,13,191,102,98,32,124,204,201,208,249,24,28,143,85,0,206,148,145,81,234,134,199,73,156,8,114,166,114,145,132,65,189,196,220,91,222,37,217,18,148,212,234,210,103,161,108,172,52,175,145,177,2,35,107,180,72,58,215,146,229,181,113,30,141,44,149,45,95,138,143,122,37,250,233,60,11,2,65,175,27,88,219,202,58,169,130,160,181,170,128,47,70,178,238,61,178,127,175,213,251,54,30,88,127,56,48,125,86,244,188,219,139,43,52,133,38,118,107,47,71,175,200,165,23,6,55,154,86,146,211,210,29,219,86,10,226,158,53,29,94,115,242,70,115,34,58,4,3,38,191,127,57,43,95,18,124,4,0,0 };
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

