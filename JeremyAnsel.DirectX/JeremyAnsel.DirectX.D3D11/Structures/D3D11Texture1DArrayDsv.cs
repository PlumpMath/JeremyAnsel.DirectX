﻿// <copyright file="D3D11Texture1DArrayDsv.cs" company="Jérémy Ansel">
// Copyright (c) 2014-2016 Jérémy Ansel
// </copyright>

namespace JeremyAnsel.DirectX.D3D11
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Specifies the subresources from an array of 1D textures to use in a depth-stencil view.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct D3D11Texture1DArrayDsv : IEquatable<D3D11Texture1DArrayDsv>
    {
        /// <summary>
        /// The index of the first mipmap level to use.
        /// </summary>
        private uint mipSlice;

        /// <summary>
        /// The index of the first texture to use in an array of textures.
        /// </summary>
        private uint firstArraySlice;

        /// <summary>
        /// The number of textures to use.
        /// </summary>
        private uint arraySize;

        /// <summary>
        /// Gets or sets the index of the first mipmap level to use.
        /// </summary>
        public uint MipSlice
        {
            get { return this.mipSlice; }
            set { this.mipSlice = value; }
        }

        /// <summary>
        /// Gets or sets the index of the first texture to use in an array of textures.
        /// </summary>
        public uint FirstArraySlice
        {
            get { return this.firstArraySlice; }
            set { this.firstArraySlice = value; }
        }

        /// <summary>
        /// Gets or sets the number of textures to use.
        /// </summary>
        public uint ArraySize
        {
            get { return this.arraySize; }
            set { this.arraySize = value; }
        }

        /// <summary>
        /// Compares two <see cref="D3D11Texture1DArrayDsv"/> objects. The result specifies whether the values of the two objects are equal.
        /// </summary>
        /// <param name="left">The left <see cref="D3D11Texture1DArrayDsv"/> to compare.</param>
        /// <param name="right">The right <see cref="D3D11Texture1DArrayDsv"/> to compare.</param>
        /// <returns><value>true</value> if the values of left and right are equal; otherwise, <value>false</value>.</returns>
        public static bool operator ==(D3D11Texture1DArrayDsv left, D3D11Texture1DArrayDsv right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two <see cref="D3D11Texture1DArrayDsv"/> objects. The result specifies whether the values of the two objects are unequal.
        /// </summary>
        /// <param name="left">The left <see cref="D3D11Texture1DArrayDsv"/> to compare.</param>
        /// <param name="right">The right <see cref="D3D11Texture1DArrayDsv"/> to compare.</param>
        /// <returns><value>true</value> if the values of left and right differ; otherwise, <value>false</value>.</returns>
        public static bool operator !=(D3D11Texture1DArrayDsv left, D3D11Texture1DArrayDsv right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><value>true</value> if the specified object is equal to the current object; otherwise, <value>false</value>.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is D3D11Texture1DArrayDsv))
            {
                return false;
            }

            return this.Equals((D3D11Texture1DArrayDsv)obj);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="other">The object to compare with the current object.</param>
        /// <returns><value>true</value> if the specified object is equal to the current object; otherwise, <value>false</value>.</returns>
        public bool Equals(D3D11Texture1DArrayDsv other)
        {
            return this.mipSlice == other.mipSlice
                && this.firstArraySlice == other.firstArraySlice
                && this.arraySize == other.arraySize;
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return new
            {
                this.mipSlice,
                this.firstArraySlice,
                this.arraySize
            }
            .GetHashCode();
        }
    }
}
