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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,81,209,78,2,49,16,124,62,18,254,97,131,47,144,144,251,0,80,31,4,52,38,162,6,228,3,74,187,28,213,210,158,219,222,5,98,252,119,183,87,212,131,132,75,31,174,187,51,211,157,89,43,118,232,75,33,17,222,144,72,120,183,9,249,196,217,141,46,42,18,65,59,11,95,221,78,86,121,109,11,88,30,124,192,221,248,236,206,112,99,80,70,172,207,31,208,34,105,249,143,105,171,18,94,170,231,51,27,116,208,232,47,2,166,119,177,197,231,138,176,136,99,77,140,240,126,4,11,148,142,212,202,26,109,63,144,186,29,70,148,213,218,104,9,50,2,206,250,48,130,59,225,49,21,103,123,148,85,112,20,29,50,237,95,153,141,4,170,36,183,248,129,215,70,45,33,142,202,167,154,253,149,71,98,142,77,25,64,117,114,29,194,227,84,55,127,130,14,215,172,203,222,134,224,214,239,220,190,133,82,16,231,31,144,252,32,234,103,217,8,214,60,95,255,92,163,133,107,246,145,101,105,134,133,46,182,225,165,196,227,170,110,96,41,183,184,19,173,230,19,214,104,124,62,17,118,166,116,24,39,110,108,204,246,18,203,200,154,163,247,162,64,38,247,154,45,28,146,70,254,7,200,159,93,195,184,119,148,175,74,37,2,246,26,157,239,99,108,104,85,74,238,52,198,57,134,173,83,173,4,179,172,201,144,92,96,91,168,192,213,188,98,173,16,106,167,21,76,209,176,193,63,47,253,95,163,105,166,124,41,106,236,215,194,232,248,254,2,63,43,77,168,70,176,17,198,227,224,210,56,205,139,169,126,82,238,118,184,216,254,126,0,35,185,201,240,6,3,0,0 };
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

