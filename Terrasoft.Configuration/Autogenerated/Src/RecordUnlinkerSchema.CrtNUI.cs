namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RecordUnlinkerSchema

	/// <exclude/>
	public class RecordUnlinkerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RecordUnlinkerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RecordUnlinkerSchema(RecordUnlinkerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("66bb5f4d-9a35-4ffa-80c6-0587b0525470");
			Name = "RecordUnlinker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,81,209,110,26,49,16,124,62,36,254,97,149,190,16,41,186,15,32,109,31,2,180,138,148,180,21,148,15,48,246,112,184,53,246,117,237,59,5,85,253,247,174,207,36,1,36,78,126,56,239,206,140,119,102,189,218,35,182,74,131,126,130,89,197,176,77,245,44,248,173,109,58,86,201,6,79,127,199,163,170,139,214,55,180,58,196,132,253,253,197,93,224,206,65,103,108,172,191,194,131,173,126,199,156,170,50,174,213,235,133,79,54,89,196,171,128,249,67,110,201,249,192,104,242,88,51,167,98,156,210,18,58,176,89,123,103,253,111,240,120,36,136,182,219,56,171,73,103,192,69,159,166,244,160,34,74,113,241,2,221,165,192,217,161,208,222,149,197,72,226,78,75,75,30,248,49,168,21,196,81,249,92,115,178,142,96,225,248,146,1,117,103,215,59,122,156,219,225,79,241,225,163,232,138,183,59,10,155,95,210,254,76,173,98,201,63,129,227,109,214,175,170,41,109,100,190,201,165,198,9,110,216,71,85,149,25,150,182,217,165,239,45,142,171,250,68,43,189,195,94,157,52,159,208,195,197,122,166,252,194,216,116,95,184,185,177,120,209,104,51,235,25,49,170,6,66,190,25,182,112,40,26,245,27,160,254,22,6,198,151,192,245,186,53,42,225,102,208,249,119,140,13,222,148,228,206,99,124,70,218,5,115,146,96,85,13,25,114,72,98,11,134,66,47,43,182,6,212,7,107,104,14,39,6,223,188,76,94,141,150,153,234,149,234,49,233,149,179,249,253,37,254,116,150,97,166,180,85,46,226,246,218,56,195,139,165,126,86,30,143,164,152,191,255,112,67,0,71,254,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("66bb5f4d-9a35-4ffa-80c6-0587b0525470"));
		}

		#endregion

	}

	#endregion

}

