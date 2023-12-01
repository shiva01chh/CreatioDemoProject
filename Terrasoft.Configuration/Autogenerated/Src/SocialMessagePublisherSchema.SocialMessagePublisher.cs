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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,193,78,195,48,12,134,207,173,212,119,176,198,101,72,211,30,160,3,14,108,192,9,132,84,120,0,47,243,186,72,105,58,217,201,161,170,120,119,156,116,18,42,131,40,82,226,63,159,127,199,142,98,125,11,205,32,129,186,245,182,119,142,76,176,189,151,245,11,121,98,107,54,85,25,51,242,65,204,40,253,49,40,197,164,114,85,122,236,72,206,104,104,246,232,143,182,141,140,201,165,42,199,170,44,116,223,48,181,26,195,214,161,72,13,77,111,44,186,87,18,193,150,222,227,222,89,57,17,39,203,226,156,34,3,38,129,255,112,80,195,35,10,93,167,23,99,182,248,169,166,125,4,142,38,244,92,67,230,204,4,92,138,252,109,191,252,20,98,77,245,211,36,32,206,194,21,236,108,190,32,15,119,234,174,163,89,193,116,62,0,249,96,195,240,108,201,29,100,135,1,111,83,177,162,134,189,126,119,249,219,231,10,134,49,227,79,89,111,204,137,58,124,211,9,195,61,44,102,63,93,108,18,247,117,233,149,252,97,106,55,199,147,58,23,85,211,245,13,165,40,204,97,233,1,0,0 };
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

