import React from 'react';
import {View, Text, FlatList, Dimensions} from 'react-native';
import Customer from "../Customer";

import styles from './styles';
import customers from './customers';

const CustomersList = (props) => {
  return (
    <View style={styles.container}>
      <FlatList
        data={customers}
        renderItem={({item}) => <Customer customer={item} />}
        showsVerticalScrollIndicator={false}
        snapToAlignment={'start'}
        decelerationRate={'fast'}
        snapToInterval={Dimensions.get('window').height}
      />
    </View>
  );
};

export default CustomersList;
