namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NumberRUExpressionConveterSchema

	/// <exclude/>
	public class NumberRUExpressionConveterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NumberRUExpressionConveterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NumberRUExpressionConveterSchema(NumberRUExpressionConveterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d1467aa9-7149-4dab-9d97-0660599142d3");
			Name = "NumberRUExpressionConveter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("14a29563-3c13-443c-a7aa-8d0c90d831c2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,79,61,11,194,80,12,156,45,244,63,132,78,10,242,192,73,212,81,93,21,252,152,196,225,181,166,245,65,251,94,73,242,68,81,255,187,169,46,46,13,183,228,238,114,71,188,109,144,91,91,32,28,144,200,114,40,197,44,131,47,93,21,201,138,11,62,77,158,105,50,136,236,124,5,251,7,11,54,11,221,21,167,109,206,161,70,193,97,54,53,51,51,129,23,172,2,248,32,16,25,65,174,142,161,168,45,243,24,156,215,51,123,249,242,61,45,102,19,155,28,105,119,92,223,91,66,102,165,84,191,33,9,82,54,58,107,93,27,243,218,21,191,72,232,113,171,25,230,125,98,23,5,26,212,189,243,78,19,197,255,124,0,157,22,243,234,8,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d1467aa9-7149-4dab-9d97-0660599142d3"));
		}

		#endregion

	}

	#endregion

}

