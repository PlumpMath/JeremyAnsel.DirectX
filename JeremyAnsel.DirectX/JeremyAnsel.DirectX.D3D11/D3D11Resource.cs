﻿// <copyright file="D3D11Resource.cs" company="Jérémy Ansel">
// Copyright (c) 2014-2016 Jérémy Ansel
// </copyright>

namespace JeremyAnsel.DirectX.D3D11
{
    using System.Runtime.CompilerServices;
    using JeremyAnsel.DirectX.D3D11.ComInterfaces;
    using JeremyAnsel.DirectX.Dxgi;

    /// <summary>
    /// A resource interface provides common actions on all resources.
    /// </summary>
    public abstract class D3D11Resource : D3D11DeviceChild
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="D3D11Resource"/> class.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal D3D11Resource()
        {
        }

        /// <summary>
        /// Gets the type of the resource.
        /// </summary>
        public D3D11ResourceDimension Dimension
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                D3D11ResourceDimension dimension;
                this.GetHandle<ID3D11Resource>().GetDimension(out dimension);
                return dimension;
            }
        }

        /// <summary>
        /// Gets or sets the eviction priority of a resource.
        /// </summary>
        public DxgiResourceEvictionPriority EvictionPriority
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return this.GetHandle<ID3D11Resource>().GetEvictionPriority(); }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { this.GetHandle<ID3D11Resource>().SetEvictionPriority(value); }
        }
    }
}
