namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateTimeExpressionConveterSchema

	/// <exclude/>
	public class DateTimeExpressionConveterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateTimeExpressionConveterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateTimeExpressionConveterSchema(DateTimeExpressionConveterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("35da4edf-d91a-423a-87ed-e938ea1f0686");
			Name = "DateTimeExpressionConveter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("14a29563-3c13-443c-a7aa-8d0c90d831c2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,79,177,10,194,64,12,157,45,244,31,66,39,5,57,112,18,117,180,206,14,118,19,135,107,77,107,160,119,87,46,57,81,212,127,55,213,185,225,45,121,239,229,61,226,173,67,30,108,131,80,97,140,150,67,43,102,31,124,75,93,138,86,40,248,60,123,229,217,44,49,249,14,78,79,22,116,59,221,21,231,99,205,161,71,193,121,177,54,27,179,130,55,148,1,124,16,72,140,32,55,98,104,122,203,188,4,242,122,102,175,63,126,162,197,148,86,176,34,135,135,199,16,145,89,41,213,239,24,5,99,177,184,104,221,144,234,158,154,127,36,76,184,213,12,219,41,113,140,210,156,241,155,79,158,41,198,249,2,74,88,58,65,255,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("35da4edf-d91a-423a-87ed-e938ea1f0686"));
		}

		#endregion

	}

	#endregion

}

