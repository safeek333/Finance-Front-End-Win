import React from 'react';
import {View, Text, ImageBackground} from 'react-native';
import StyledButton from "../StyledButton";
import styles from './styles';
import GenQRCode from "../GenQRCode";

const Customer = (props) => {

  const { name, tagline, taglineCTA, image } = props.customer;

  return (
    <View style={styles.customerContainer}>
      <ImageBackground
        source={image}
        style={styles.image}
      />

      <View style={styles.titles}>
        <Text style={styles.title}>{name}</Text>
        <Text style={styles.subtitle}>
          {tagline}          
        </Text>      
        <Text style={styles.subtitleCTA}>
            {'\n'}{taglineCTA} {'\n'}
        </Text>
      </View>

      <View style={styles.buttonsContainer}>
        <StyledButton
          type="primary"
          content={"Collect EMI Amount"}
          onPress={() => {
            console.warn("Amount Collected Successfully.");
          }}
        />

        <StyledButton
          type="secondary"
          content={"View Collected Details"}
          onPress={() => {
            console.warn("Collected Details Not Available");
          }}
        />
      </View>
        <GenQRCode>
    </GenQRCode>
    </View>
  
  );
};

export default Customer;
