//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.disputes.slashing.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> report_dispute_lost_unsigned
        /// See [`Pallet::report_dispute_lost_unsigned`].
        /// </summary>
        report_dispute_lost_unsigned = 0,
    }
    
    /// <summary>
    /// >> 371 - Variant[polkadot_runtime_parachains.disputes.slashing.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.slashing.DisputeProof, Polkadot.NetApi.Generated.Model.sp_session.MembershipProof>>
    {
    }
}