namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SocialMessagePublisherSchema

	/// <exclude/>
	public class SocialMessagePublisherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SocialMessagePublisherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SocialMessagePublisherSchema(SocialMessagePublisherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("338fe51c-5d19-4505-9d2c-889953ea22f6");
			Name = "SocialMessagePublisher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("203eb078-3e33-4e60-b9e9-a0b134c55d99");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,193,78,195,48,12,134,207,173,212,119,176,198,101,72,211,30,160,3,14,219,128,19,8,105,240,0,94,230,117,145,210,116,178,147,67,85,241,238,56,233,36,40,131,40,82,226,63,159,127,199,142,98,125,3,187,94,2,181,203,77,231,28,153,96,59,47,203,103,242,196,214,172,170,50,102,228,157,152,81,186,99,80,138,73,229,170,244,216,146,156,209,208,228,209,31,109,19,25,147,75,85,14,85,89,232,190,97,106,52,134,141,67,145,26,118,157,177,232,94,72,4,27,122,139,123,103,229,68,156,44,139,115,138,12,152,4,254,195,65,13,107,20,186,78,47,134,108,241,93,77,251,8,28,77,232,184,134,204,153,17,184,20,249,219,126,254,33,196,154,234,199,73,64,156,132,11,216,218,124,65,238,239,212,93,71,179,128,241,124,0,242,193,134,254,201,146,59,200,22,3,222,166,98,69,13,123,253,238,252,183,207,21,12,67,198,31,179,190,51,39,106,241,85,39,12,247,48,155,252,116,182,74,220,231,165,87,242,135,177,221,28,143,234,84,84,237,231,250,2,23,21,25,153,242,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("338fe51c-5d19-4505-9d2c-889953ea22f6"));
		}

		#endregion

	}

	#endregion

}

