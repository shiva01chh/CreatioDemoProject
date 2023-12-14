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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,77,111,219,48,12,61,167,64,255,3,225,93,210,139,125,111,62,128,180,104,183,1,43,86,172,11,122,24,134,129,177,233,76,152,44,25,148,108,44,43,246,223,71,75,118,81,59,93,219,28,28,232,241,241,137,122,36,13,86,228,106,204,9,190,18,51,58,91,250,244,210,154,82,237,27,70,175,172,57,61,121,56,61,153,53,78,153,253,136,194,180,120,6,191,167,157,196,170,202,26,137,74,252,29,211,94,68,224,82,163,115,231,112,131,74,75,194,166,174,175,90,50,254,147,114,158,12,113,160,102,89,6,75,215,84,21,242,97,221,159,191,80,205,228,132,233,160,34,255,211,22,14,188,5,101,148,87,168,213,31,2,169,252,23,238,41,29,242,179,39,2,117,179,211,42,135,188,187,250,127,55,195,57,76,161,11,116,36,217,15,161,168,199,7,92,43,210,133,188,224,150,85,139,158,98,176,142,7,216,58,98,49,205,80,222,57,6,63,154,209,121,209,43,145,41,162,216,88,249,38,62,236,109,210,239,201,143,145,249,80,190,64,158,126,123,200,227,255,25,116,109,155,205,84,9,243,73,61,176,90,129,105,180,30,40,179,22,25,176,174,133,49,16,6,149,84,212,197,195,48,8,223,146,77,224,244,164,228,59,160,131,17,180,136,114,71,215,141,196,211,187,131,248,92,109,167,22,73,226,223,240,101,242,13,63,103,98,32,188,205,201,208,249,24,156,142,85,0,46,148,145,81,234,135,199,73,156,8,114,166,114,149,132,65,189,198,220,91,62,36,217,26,148,212,234,210,71,161,108,170,180,172,145,177,2,35,107,180,74,122,215,146,245,71,227,60,26,89,42,91,62,21,159,244,74,244,211,101,22,4,130,94,63,176,182,149,117,82,5,65,107,85,1,159,141,100,221,121,100,255,90,171,187,54,30,89,127,60,48,67,86,244,188,223,139,15,104,10,77,236,182,94,142,94,145,75,175,12,238,52,109,36,167,165,91,182,173,20,196,3,107,62,190,230,236,133,230,68,116,12,6,172,251,253,3,176,209,192,109,125,4,0,0 };
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

