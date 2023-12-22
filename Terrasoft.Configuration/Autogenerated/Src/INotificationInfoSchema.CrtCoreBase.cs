namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationInfoSchema

	/// <exclude/>
	public class INotificationInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationInfoSchema(INotificationInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aee85563-7cba-4466-bec1-e9df72ba319c");
			Name = "INotificationInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,148,93,110,194,48,16,132,159,65,226,14,123,2,114,0,170,74,253,19,138,212,242,0,244,0,38,222,132,173,240,26,217,155,135,8,245,238,181,13,168,169,32,45,110,148,88,249,241,204,151,25,57,97,101,208,239,85,133,176,70,231,148,183,181,76,159,44,215,212,180,78,9,89,158,140,15,147,241,168,245,196,13,172,58,47,104,102,225,58,236,69,81,192,157,111,141,81,174,187,63,93,151,44,232,234,232,86,91,7,196,97,52,201,5,108,13,178,69,96,43,84,83,149,238,77,207,38,69,207,101,223,110,118,84,5,233,217,168,92,244,36,101,112,12,147,226,27,93,240,211,141,53,201,14,135,96,151,180,145,23,23,131,29,101,7,104,80,102,224,227,240,25,159,14,98,30,173,238,242,41,73,117,59,164,212,200,223,214,103,28,25,213,224,0,103,222,146,134,50,78,40,117,6,104,137,149,117,26,232,196,67,7,118,243,129,149,100,36,76,228,151,32,151,46,11,189,170,182,104,20,112,88,133,249,125,30,121,71,139,69,116,200,239,54,100,189,53,221,27,122,127,181,217,65,200,179,18,4,197,26,132,178,226,69,221,58,74,150,104,136,117,58,189,149,217,255,90,96,103,149,142,9,67,55,191,55,249,154,38,254,179,195,159,235,83,163,23,226,63,219,12,191,146,7,29,210,189,51,73,6,115,238,108,187,255,231,114,73,218,171,25,195,145,58,237,111,95,195,238,41,84,25,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aee85563-7cba-4466-bec1-e9df72ba319c"));
		}

		#endregion

	}

	#endregion

}

