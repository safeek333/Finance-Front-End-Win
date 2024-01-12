import { StyleSheet, Dimensions } from 'react-native';

const styles = StyleSheet.create({
  customerContainer: {
    width: '100%',
    height: Dimensions.get('window').height,
  },
  titles: {
    marginTop: '30%',
    width: '100%',
    alignItems: 'center',
    backgroundColor: 'yellow',
    opacity: 0.6
  },
  title: {
    fontSize: 40,
    fontWeight: '500',
  },
  subtitleCTA: {
    fontSize: 26,
    color: 'red',
    textDecorationLine: 'underline',
    textDecorationStyle :'double'
  },
  subtitle: {
    fontSize: 20,
    color: 'white',
    backgroundColor: 'green'
  },

  image: {
    width: '100%',
    height: '100%',
    resizeMode: 'cover',
    position: 'absolute',
  },

  buttonsContainer: {
    position: 'absolute',
    bottom: 50,
    width: '100%',
  }
});

export default styles;
