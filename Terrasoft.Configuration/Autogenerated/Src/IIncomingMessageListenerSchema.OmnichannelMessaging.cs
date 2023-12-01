namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IIncomingMessageListenerSchema

	/// <exclude/>
	public class IIncomingMessageListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IIncomingMessageListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IIncomingMessageListenerSchema(IIncomingMessageListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e4621d47-b46b-4fa0-8ceb-e6a359374028");
			Name = "IIncomingMessageListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("92ff52b6-dfba-4556-90d8-6f4c37f69c5d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,145,207,106,195,48,12,198,207,13,228,29,68,119,217,46,241,189,203,122,233,41,176,254,97,108,15,224,37,74,106,136,229,32,57,131,49,246,238,115,237,36,116,49,190,248,243,167,31,159,36,210,22,101,208,53,194,59,50,107,113,173,47,14,142,90,211,141,172,189,113,84,156,45,153,250,170,137,176,47,142,40,162,59,67,93,158,253,228,89,158,109,30,24,187,96,130,138,60,114,27,48,59,168,42,170,157,13,158,100,198,147,243,166,53,200,209,175,148,130,82,70,107,53,127,239,167,247,27,14,140,130,228,5,204,140,129,214,49,244,70,60,82,32,5,61,33,193,38,166,20,48,195,212,29,109,24,63,123,83,223,81,214,89,94,35,241,150,101,147,242,47,13,28,209,95,93,35,59,184,68,70,250,92,167,141,194,37,176,29,91,1,93,223,230,3,225,174,227,21,75,177,90,87,151,131,102,109,129,194,216,95,182,147,125,187,175,214,128,82,69,95,44,251,114,166,129,143,161,209,30,31,151,5,76,13,205,5,79,207,83,59,72,77,234,40,190,127,211,146,254,137,65,11,231,15,146,67,10,22,248,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e4621d47-b46b-4fa0-8ceb-e6a359374028"));
		}

		#endregion

	}

	#endregion

}

