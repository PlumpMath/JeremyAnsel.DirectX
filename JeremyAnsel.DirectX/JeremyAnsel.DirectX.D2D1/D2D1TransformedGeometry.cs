﻿// <copyright file="D2D1TransformedGeometry.cs" company="Jérémy Ansel">
// Copyright (c) 2014-2016 Jérémy Ansel
// </copyright>

namespace JeremyAnsel.DirectX.D2D1
{
    using System.Runtime.CompilerServices;
    using JeremyAnsel.DirectX.D2D1.ComInterfaces;

    /// <summary>
    /// Represents a geometry that has been transformed.
    /// </summary>
    public sealed class D2D1TransformedGeometry : D2D1Geometry
    {
        /// <summary>
        /// The D2D1 geometry interface.
        /// </summary>
        private ID2D1TransformedGeometry geometry;

        /// <summary>
        /// Initializes a new instance of the <see cref="D2D1TransformedGeometry"/> class.
        /// </summary>
        /// <param name="geometry">A D2D1 geometry interface.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal D2D1TransformedGeometry(ID2D1TransformedGeometry geometry)
        {
            this.geometry = geometry;
        }

        /// <summary>
        /// Gets an handle representing the D2D1 object interface.
        /// </summary>
        public override object Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return this.geometry; }
        }

        /// <summary>
        /// Gets the source geometry of this transformed geometry object.
        /// </summary>
        public D2D1Geometry SourceGeometry
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ID2D1Geometry sourceGeometry;
                this.geometry.GetSourceGeometry(out sourceGeometry);
                return new D2D1GeometryBase(sourceGeometry);
            }
        }

        /// <summary>
        /// Gets the matrix used to transform the <see cref="D2D1TransformedGeometry"/> object's source geometry.
        /// </summary>
        public D2D1Matrix3X2F Transform
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                D2D1Matrix3X2F transform;
                this.geometry.GetTransform(out transform);
                return transform;
            }
        }
    }
}
