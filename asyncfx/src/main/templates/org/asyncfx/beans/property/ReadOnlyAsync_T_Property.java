/**
 *
 * SPDX-License-Identifier: GPL-3.0-or-later
 */
// This file was generated by a tool. Do not edit.
//
package org.asyncfx.beans.property;

import javafx.beans.binding.${boxedType}Expression;
import org.asyncfx.PublishSource;
import org.asyncfx.beans.value.AsyncSubObservableValue;

@PublishSource(module = "openjfx", licenses = "intel-gpl-classpath-exception")
public abstract class ReadOnlyAsync${boxedType}Property$!{genericType}
        extends ${boxedType}Expression$!{genericType}
        implements ReadOnlyAsyncProperty<${numberType}> $!{additionalImplements} {

    /** Gets the value of this property, regardless of whether it is protected by a {@link ConsistencyGroup}. */
    public abstract ${primType} getUncritical();

    @Override
    public ${numberType} getValueUncritical() {
        return getUncritical();
    }

}