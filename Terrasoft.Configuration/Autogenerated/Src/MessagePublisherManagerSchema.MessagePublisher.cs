namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MessagePublisherManagerSchema

	/// <exclude/>
	public class MessagePublisherManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MessagePublisherManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MessagePublisherManagerSchema(MessagePublisherManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f427a0bd-0b35-4b26-946c-3c6a5598a4f9");
			Name = "MessagePublisherManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7c74fc90-4a57-4e68-9eda-fe0982d1250d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,82,193,74,3,49,16,61,71,240,31,70,122,217,66,217,15,80,171,72,69,233,161,82,80,241,40,113,119,218,70,183,73,153,100,43,75,241,223,157,36,219,186,187,109,5,193,30,90,102,250,242,222,188,55,163,229,18,237,74,102,8,79,72,36,173,153,185,116,100,244,76,205,75,146,78,25,125,122,178,57,61,17,165,85,122,14,143,149,117,184,188,232,212,140,47,10,204,60,216,166,247,168,145,84,246,131,105,210,18,30,235,167,119,50,115,134,20,90,70,48,166,71,56,103,62,24,21,210,218,115,152,160,181,114,142,211,242,173,80,118,129,52,145,154,75,10,208,149,111,102,144,121,228,113,160,216,4,240,142,248,78,97,193,196,83,82,107,233,48,138,138,85,172,128,80,230,70,23,21,60,91,36,78,67,71,119,240,90,182,234,250,85,15,117,30,89,219,18,12,180,142,74,239,139,133,194,148,181,76,156,248,200,172,73,71,180,173,217,7,191,14,33,58,163,192,16,246,102,19,226,235,247,1,39,232,22,38,255,73,161,29,130,121,123,103,42,184,71,55,102,31,82,103,152,176,29,191,186,16,245,3,31,206,0,110,85,80,147,84,93,198,63,7,16,127,175,96,198,9,231,246,86,58,185,157,121,45,9,62,13,125,132,123,123,170,86,56,37,179,86,57,18,79,31,22,29,143,160,226,35,114,151,227,151,67,200,171,164,31,156,9,223,4,231,191,134,135,57,61,137,175,147,221,180,245,75,66,87,146,142,111,207,134,160,203,162,128,107,184,97,31,108,219,80,58,226,237,59,220,121,246,184,65,119,243,131,150,187,243,64,242,183,196,247,207,97,109,84,14,245,49,252,71,210,203,206,121,113,80,201,184,123,115,253,230,122,27,106,13,202,152,154,154,65,178,199,88,199,183,85,21,93,64,186,181,83,147,124,29,143,40,118,219,205,208,107,126,190,1,96,36,238,150,173,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f427a0bd-0b35-4b26-946c-3c6a5598a4f9"));
		}

		#endregion

	}

	#endregion

}

