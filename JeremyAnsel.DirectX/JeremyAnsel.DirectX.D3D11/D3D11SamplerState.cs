﻿// <copyright file="D3D11SamplerState.cs" company="Jérémy Ansel">
// Copyright (c) 2014-2016 Jérémy Ansel
// </copyright>

namespace JeremyAnsel.DirectX.D3D11
{
    using System.Runtime.CompilerServices;
    using JeremyAnsel.DirectX.D3D11.ComInterfaces;

    /// <summary>
    /// The sampler-state interface holds a description for sampler state that you can bind to any shader stage of the pipeline for reference by texture sample operations.
    /// </summary>
    public sealed class D3D11SamplerState : D3D11DeviceChild
    {
        /// <summary>
        /// The D3D11 sampler state interface.
        /// </summary>
        private ID3D11SamplerState samplerState;

        /// <summary>
        /// Initializes a new instance of the <see cref="D3D11SamplerState"/> class.
        /// </summary>
        /// <param name="samplerState">A D3D11 sampler state interface.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal D3D11SamplerState(ID3D11SamplerState samplerState)
        {
            this.samplerState = samplerState;
        }

        /// <summary>
        /// Gets an handle representing the D3D11 object interface.
        /// </summary>
        public override object Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return this.samplerState; }
        }

        /// <summary>
        /// Gets the description for sampler state that you used to create the sampler-state object.
        /// </summary>
        public D3D11SamplerDesc Description
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                D3D11SamplerDesc desc;
                this.samplerState.GetDesc(out desc);
                return desc;
            }
        }
    }
}
